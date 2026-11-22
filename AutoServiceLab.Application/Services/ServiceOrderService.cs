using AutoServiceLab.Application.Contracts.Dtos.Cars;
using AutoServiceLab.Application.Contracts.Dtos.Clients;
using AutoServiceLab.Application.Contracts.Dtos.Mechanics;
using AutoServiceLab.Application.Contracts.Dtos.ServiceOrders;
using AutoServiceLab.Application.Contracts.Dtos.WorkTypes;
using AutoServiceLab.Application.Contracts.Interfaces;
using AutoServiceLab.Domain.Entities;
using AutoServiceLab.Domain.Repositories;
using Microsoft.Extensions.Logging;

namespace AutoServiceLab.Application.Services;

/// <summary>
/// Сервис для работы с заказами
/// </summary>
public class ServiceOrderService(
    IServiceOrderRepository repository,
    IClientRepository clientRepo,
    ICarRepository carRepo,
    IOrderWorkRepository orderWorkRepo,
    IOrderMechanicRepository orderMechanicRepo,
    ILogger<ServiceOrderService> logger) : IServiceOrderService
{
    /// <inheritdoc />
    public async Task<IList<ServiceOrderDto>> GetAllAsync()
    {
        logger.LogInformation("Получение списка всех заказов");
        var orders = await repository.GetAllAsync();
        var result = new List<ServiceOrderDto>();
        foreach (var o in orders)
        {
            result.Add(await MapToDtoAsync(o));
        }
        return result;
    }

    /// <inheritdoc />
    public async Task<ServiceOrderDto?> GetAsync(int id)
    {
        logger.LogInformation("Получение заказа с ID: {Id}", id);
        var o = await repository.GetAsync(id);
        return o == null ? null : await MapToDtoAsync(o);
    }

    /// <inheritdoc />
    public async Task<ServiceOrderDto> CreateAsync(ServiceOrderCreateUpdateDto dto)
    {
        logger.LogInformation("Создание заказа для клиента {ClientId}", dto.ClientId);
        var order = new ServiceOrder
        {
            ReceptionDate = DateTime.Now,
            IssueDate = dto.IssueDate,
            ClientId = dto.ClientId,
            Client = await clientRepo.GetAsync(dto.ClientId) ?? throw new KeyNotFoundException("Клиент не найден"),
            CarId = dto.CarId,
            Car = await carRepo.GetAsync(dto.CarId) ?? throw new KeyNotFoundException("Машина не найдена")
        };
        await repository.AddAsync(order);
        return await MapToDtoAsync(order);
    }

    /// <inheritdoc />
    public async Task<ServiceOrderDto> UpdateAsync(ServiceOrderCreateUpdateDto dto, int id)
    {
        logger.LogInformation("Обновление заказа с ID: {Id}", id);
        var order = await repository.GetAsync(id) ?? throw new KeyNotFoundException();
        order.IssueDate = dto.IssueDate;
        order.ClientId = dto.ClientId;
        order.Client = await clientRepo.GetAsync(dto.ClientId) ?? throw new KeyNotFoundException("Клиент не найден");
        order.CarId = dto.CarId;
        order.Car = await carRepo.GetAsync(dto.CarId) ?? throw new KeyNotFoundException("Машина не найдена");
        await repository.UpdateAsync(order);
        return await MapToDtoAsync(order);
    }

    /// <inheritdoc />
    public async Task<bool> DeleteAsync(int id)
    {
        logger.LogInformation("Удаление заказа с ID: {Id}", id);
        return await repository.DeleteAsync(id);
    }

    /// <inheritdoc />
    public async Task<IList<string>> GetWorksByOrder(int orderId)
    {
        logger.LogInformation("Получение работ для заказа с ID: {OrderId}", orderId);
        return (await orderWorkRepo.GetAllAsync())
            .Where(ow => ow.ServiceOrderId == orderId)
            .Select(ow => ow.WorkType?.Name ?? "Неизвестно")
            .ToList();
    }

    /// <summary>
    /// Вспомогательный метод для преобразования сущности в DTO
    /// </summary>
    private async Task<ServiceOrderDto> MapToDtoAsync(ServiceOrder o)
    {
        var works = (await orderWorkRepo.GetAllAsync())
            .Where(ow => ow.ServiceOrderId == o.Id)
            .Select(ow => new WorkTypeDto(ow.WorkType.Id, ow.WorkType.Name, ow.WorkType.Category, ow.WorkType.Duration, ow.WorkType.LaborCost))
            .ToList();

        var mechanics = (await orderMechanicRepo.GetAllAsync())
            .Where(om => om.ServiceOrderId == o.Id)
            .Select(om => new MechanicDto(om.Mechanic.Id, om.Mechanic.FullName, om.Mechanic.Specialization, om.Mechanic.ExperienceYears))
            .ToList();

        var clientDto = new ClientDto(o.Client.Id, o.Client.FullName, o.Client.Phone);
        var carDto = new CarDto(o.Car.Id, o.Car.LicensePlate, o.Car.Brand, o.Car.Model, o.Car.Year, o.Car.ClientId);

        return new ServiceOrderDto(
            o.Id,
            o.ReceptionDate,
            o.IssueDate,
            clientDto,
            carDto,
            works,
            mechanics
        );
    }
}
