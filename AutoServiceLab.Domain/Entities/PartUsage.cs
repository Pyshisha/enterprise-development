namespace AutoServiceLab.Domain.Entities;

/// <summary>
/// Использование запчасти в заказе
/// </summary>
public class PartUsage
{
    /// <summary>
    /// Идентификатор использования
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Количество использованных запчастей
    /// </summary>
    public int Quantity { get; set; }

    /// <summary>
    /// Цена запчасти на момент использования
    /// </summary>
    public decimal PriceAtTime { get; set; }

    /// <summary>
    /// Общая стоимость использованных запчастей
    /// </summary>
    public decimal TotalCost => Quantity * PriceAtTime;

    /// <summary>
    /// Дата использования запчасти
    /// </summary>
    public DateTime UsedDate { get; set; } = DateTime.Now;

    /// <summary>
    /// Идентификатор запчасти
    /// </summary>
    public int PartId { get; set; }

    /// <summary>
    /// Запчасть
    /// </summary>
    public Part Part { get; set; } = null!;

    /// <summary>
    /// Идентификатор заказа
    /// </summary>
    public int ServiceOrderId { get; set; }

    /// <summary>
    /// Заказ
    /// </summary>
    public ServiceOrder ServiceOrder { get; set; } = null!;
}
