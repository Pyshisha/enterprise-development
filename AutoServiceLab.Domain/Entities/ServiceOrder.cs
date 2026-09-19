using AutoServiceLab.Domain.Enums;

namespace AutoServiceLab.Domain.Entities;

/// <summary>
/// Заказ на обслуживание автомобиля
/// </summary>
public class ServiceOrder
{
    /// <summary>
    /// Идентификатор заказа
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Дата создания заказа
    /// </summary>
    public DateTime CreatedDate { get; set; } = DateTime.Now;

    /// <summary>
    /// Запланированная дата выполнения
    /// </summary>
    public DateTime? ScheduledDate { get; set; }

    /// <summary>
    /// Дата завершения заказа
    /// </summary>
    public DateTime? CompletedDate { get; set; }

    /// <summary>
    /// Статус заказа
    /// </summary>
    public OrderStatus Status { get; set; } = OrderStatus.Created;

    /// <summary>
    /// Описание заказа
    /// </summary>
    public required string Description { get; set; }

    /// <summary>
    /// Стоимость работ
    /// </summary>
    public decimal LaborCost => ServiceWorks.Sum(w => w.LaborCost);

    /// <summary>
    /// Стоимость запчастей
    /// </summary>
    public decimal PartsCost => PartsUsed.Sum(p => p.PriceAtTime * p.Quantity);

    /// <summary>
    /// Общая стоимость заказа
    /// </summary>
    public decimal TotalCost => LaborCost + PartsCost;

    /// <summary>
    /// Счёт на оплату заказа
    /// </summary>
    public Invoice? Invoice { get; set; }

    /// <summary>
    /// Примечания к заказу
    /// </summary>
    public string? Notes { get; set; }

    /// <summary>
    /// Идентификатор клиента
    /// </summary>
    public int ClientId { get; set; }

    /// <summary>
    /// Клиент
    /// </summary>
    public Client Client { get; set; } = null!;

    /// <summary>
    /// Идентификатор автомобиля
    /// </summary>
    public int CarId { get; set; }

    /// <summary>
    /// Автомобиль
    /// </summary>
    public Car Car { get; set; } = null!;

    /// <summary>
    /// Список работ
    /// </summary>
    public List<ServiceWork> ServiceWorks { get; set; } = [];

    /// <summary>
    /// Список использованных запчастей
    /// </summary>
    public List<PartUsage> PartsUsed { get; set; } = [];

    /// <summary>
    /// Возвращает строковое представление заказа
    /// </summary>
    public override string ToString() => $"Заказ #{Id}: {TotalCost:C}";
}
