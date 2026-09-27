using AutoServiceLab.Domain.Enums;

namespace AutoServiceLab.Domain.Entities;

/// <summary>
/// Заказ на обслуживание автомобиля
/// </summary>
public class OrderServive
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
    /// Стоимость
    /// </summary>
    public decimal LaborCost => ServiceWorks.Sum(w => w.LaborCost);

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
    /// Список работ заказа
    /// </summary>
    public List<OrderWork> OrderWorks { get; set; } = [];

    /// <summary>
    /// Возвращает строковое представление заказа
    /// </summary>
    public override string ToString() => $"Заказ #{Id}";
}
