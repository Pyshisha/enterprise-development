using AutoServiceLab.Domain.Enums;

namespace AutoServiceLab.Domain.Entities;

/// <summary>
/// Автомобиль клиента автосервиса
/// </summary>
public class Car
{
    /// <summary>
    /// Идентификатор
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Гос. номер автомобиля
    /// </summary>
    public required string LicensePlate { get; set; }

    /// <summary>
    /// Марка автомобиля
    /// </summary>
    public required CarBrand Brand { get; set; }

    /// <summary>
    /// Модель автомобиля
    /// </summary>
    public required string Model { get; set; }

    /// <summary>
    /// Год выпуска автомобиля
    /// </summary>
    public int Year { get; set; }

    /// <summary>
    /// VIN автомобиля
    /// </summary>
    public string? VinCode { get; set; }

    /// <summary>
    /// Цвет автомобиля
    /// </summary>
    public string? Color { get; set; }

    /// <summary>
    /// Пробег автомобиля
    /// </summary>
    public int? Mileage { get; set; }

    /// <summary>
    /// Тип автомобиля
    /// </summary>
    public CarType? Type { get; set; }

    /// <summary>
    /// Тип двигателя автомобиля
    /// </summary>
    public EngineType? EngineType { get; set; }

    /// <summary>
    /// Объем двигателя автомобиля
    /// </summary>
    public int? EngineVolume { get; set; }

    /// <summary>
    /// Идентификатор клиента автосервиса
    /// </summary>
    public int ClientId { get; set; }

    /// <summary>
    /// Клиент автосервиса
    /// </summary>
    public Client Client { get; set; } = null!;

    /// <summary>
    /// Заказы на работы с автомобилем
    /// </summary>
    public List<ServiceOrder> Orders { get; set; } = [];

    /// <summary>
    /// Возвращает строковое представление автомобиля
    /// </summary>
    public override string ToString() => $"{Brand} {Model} ({Year})";
}
