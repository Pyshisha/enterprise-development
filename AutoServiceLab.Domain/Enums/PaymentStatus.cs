namespace AutoServiceLab.Domain.Enums;

/// <summary>
/// Статусы оплаты счёта
/// </summary>
public enum PaymentStatus
{
    /// <summary>
    /// Не оплачен
    /// </summary>
    Unpaid = 0,

    /// <summary>
    /// Оплачен
    /// </summary>
    Paid = 1,

    /// <summary>
    /// Частично оплачен
    /// </summary>
    PartiallyPaid = 2,

    /// <summary>
    /// Возврат средств
    /// </summary>
    Refunded = 3
}
