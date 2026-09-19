using AutoServiceLab.Domain.Enums;

namespace AutoServiceLab.Domain.Entities;

/// <summary>
/// Выполненная работа в заказе
/// </summary>
public class ServiceWork
{
    /// <summary>
    /// Идентификатор работы
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Тип работы
    /// </summary>
    public required WorkType WorkType { get; set; }

    /// <summary>
    /// Описание работы
    /// </summary>
    public required string Description { get; set; }

    /// <summary>
    /// Трудозатраты в часах
    /// </summary>
    public decimal LaborHours { get; set; }

    /// <summary>
    /// Стоимость работы
    /// </summary>
    public decimal LaborCost { get; set; }

    /// <summary>
    /// Дата выполнения работы
    /// </summary>
    public DateTime WorkDate { get; set; } = DateTime.Now;

    /// <summary>
    /// Гарантийная работа
    /// </summary>
    public bool IsWarranty { get; set; }

    /// <summary>
    /// Примечания к работе
    /// </summary>
    public string? Notes { get; set; }

    /// <summary>
    /// Идентификатор заказа
    /// </summary>
    public int ServiceOrderId { get; set; }

    /// <summary>
    /// Заказ
    /// </summary>
    public ServiceOrder ServiceOrder { get; set; } = null!;

    /// <summary>
    /// Идентификатор механика
    /// </summary>
    public int? MechanicId { get; set; }

    /// <summary>
    /// Механик
    /// </summary>
    public Mechanic? Mechanic { get; set; }
}
