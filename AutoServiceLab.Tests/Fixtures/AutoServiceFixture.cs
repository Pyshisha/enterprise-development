using AutoServiceLab.Domain.Data;
using AutoServiceLab.Domain.Entities;

namespace AutoServiceLab.Tests.Fixtures;

/// <summary>
/// Тестовый набор данных автосервиса
/// </summary>
public class AutoServiceFixture
{
    /// <summary>
    /// Список клиентов
    /// </summary>
    public readonly List<Client> Clients;

    /// <summary>
    /// Список автомобилей
    /// </summary>
    public readonly List<Car> Cars;

    /// <summary>
    /// Список механиков
    /// </summary>
    public readonly List<Mechanic> Mechanics;

    /// <summary>
    /// Список запчастей
    /// </summary>
    public readonly List<Part> Parts;

    /// <summary>
    /// Список использований запчастей
    /// </summary>
    public readonly List<PartUsage> PartUsages;

    /// <summary>
    /// Список заказов
    /// </summary>
    public readonly List<ServiceOrder> ServiceOrders;

    /// <summary>
    /// Список работ
    /// </summary>
    public readonly List<ServiceWork> ServiceWorks;

    /// <summary>
    /// Список счетов
    /// </summary>
    public readonly List<Invoice> Invoices;

    /// <summary>
    /// Создаёт тестовый набор данных
    /// </summary>
    public AutoServiceFixture()
    {
        Clients = DataSeeder.GetClients();
        Cars = DataSeeder.GetCars(Clients);
        Mechanics = DataSeeder.GetMechanics();
        Parts = DataSeeder.GetParts();
        ServiceOrders = DataSeeder.GetOrders(Clients, Cars);
        PartUsages = DataSeeder.GetPartUsages(ServiceOrders, Parts);
        ServiceWorks = DataSeeder.GetServiceWorks(ServiceOrders, Mechanics);
        Invoices = DataSeeder.GetInvoices(ServiceOrders);
    }
}
