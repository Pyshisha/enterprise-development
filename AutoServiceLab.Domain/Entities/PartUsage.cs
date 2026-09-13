namespace AutoServiceLab.Domain.Entities;

public class PartUsage
{
    public int Id { get; set; }
    public int Quantity { get; set; }
    public decimal PriceAtTime { get; set; }
    public DateTime UsedDate { get; set; } = DateTime.Now;

    public int PartId { get; set; }
    public Part Part { get; set; } = null!;
    public decimal TotalCost => Quantity * PriceAtTime;
    public int ServiceOrderId { get; set; }
    public ServiceOrder ServiceOrder { get; set; } = null!;
}
