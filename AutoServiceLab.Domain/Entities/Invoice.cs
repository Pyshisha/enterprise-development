using AutoServiceLab.Domain.Enums;

namespace AutoServiceLab.Domain.Entities;

public class Invoice
{
    public int Id { get; set; }
    public required string InvoiceNumber { get; set; }
    public DateTime InvoiceDate { get; set; } = DateTime.Now;
    public DateTime DueDate { get; set; }
    public decimal Amount { get; set; }
    public decimal PaidAmount { get; set; }
    public PaymentStatus PaymentStatus { get; set; } = PaymentStatus.Unpaid;
    public PaymentMethod PaymentMethod { get; set; }
    public DateTime? PaymentDate { get; set; }

    public int ServiceOrderId { get; set; }
    public ServiceOrder ServiceOrder { get; set; } = null!;

    public override string ToString() => $"{InvoiceNumber}: {Amount:C}";
}
