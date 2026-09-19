namespace AutoServiceLab.Domain.Enums;

/// <summary>
/// Статусы запчасти на складе
/// </summary>
public enum PartStatus
{
    /// <summary>
    /// В наличии
    /// </summary>
    InStock = 0,

    /// <summary>
    /// Нет в наличии
    /// </summary>
    OutOfStock = 1,

    /// <summary>
    /// Заказана у поставщика
    /// </summary>
    Ordered = 2,

    /// <summary>
    /// Доставлена
    /// </summary>
    Delivered = 3
}
