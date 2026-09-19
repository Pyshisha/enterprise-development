namespace AutoServiceLab.Domain.Enums;

/// <summary>
/// Статусы заказа на обслуживание
/// </summary>
public enum OrderStatus
{
    /// <summary>
    /// Создан
    /// </summary>
    Created = 0,

    /// <summary>
    /// Подтверждён
    /// </summary>
    Confirmed = 1,

    /// <summary>
    /// В работе
    /// </summary>
    InProgress = 2,

    /// <summary>
    /// Ожидает запчасти
    /// </summary>
    WaitingParts = 3,

    /// <summary>
    /// Завершён
    /// </summary>
    Completed = 4,

    /// <summary>
    /// Отменён
    /// </summary>
    Cancelled = 5
}
