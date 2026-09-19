using AutoServiceLab.Domain.Enums;

namespace AutoServiceLab.Domain.Entities;

/// <summary>
/// Счёт на оплату заказа
/// </summary>
public class Invoice
{
    /// <summary>
    /// Идентификатор счёта
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Номер счёта
    /// </summary>
    public required string InvoiceNumber { get; set; }

    /// <summary>
    /// Дата выставления счёта
    /// </summary>
    public DateTime InvoiceDate { get; set; } = DateTime.Now;

    /// <summary>
    /// Срок оплаты счёта
    /// </summary>
    public DateTime DueDate { get; set; }

    /// <summary>
    /// Сумма счёта
    /// </summary>
    public decimal Amount { get; set; }

    /// <summary>
    /// Оплаченная сумма
    /// </summary>
    public decimal PaidAmount { get; set; }

    /// <summary>
    /// Статус оплаты
    /// </summary>
    public PaymentStatus PaymentStatus { get; set; } = PaymentStatus.Unpaid;

    /// <summary>
    /// Способ оплаты
    /// </summary>
    public PaymentMethod? PaymentMethod { get; set; }

    /// <summary>
    /// Дата оплаты
    /// </summary>
    public DateTime? PaymentDate { get; set; }

    /// <summary>
    /// Идентификатор заказа
    /// </summary>
    public int ServiceOrderId { get; set; }

    /// <summary>
    /// Заказ
    /// </summary>
    public ServiceOrder ServiceOrder { get; set; } = null!;

    /// <summary>
    /// Возвращает строковое представление счёта
    /// </summary>
    public override string ToString() => $"{InvoiceNumber}: {Amount:C}";
}
