using AutoServiceLab.Domain.Enums;

namespace AutoServiceLab.Domain.Entities;

public class ServiceOrder
{
    public int Id { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.Now;
    public DateTime? ScheduledDate { get; set; }
    public DateTime? CompletedDate { get; set; }
    public OrderStatus Status { get; set; } = OrderStatus.Created;
    public required string Description { get; set; }
    public decimal LaborCost => ServiceWorks.Sum(w => w.LaborCost);
    public decimal PartsCost => PartsUsed.Sum(p => p.PriceAtTime * p.Quantity);
    public decimal TotalCost => LaborCost + PartsCost;
    public Invoice? Invoice { get; set; }
    public string? Notes { get; set; }

    public int ClientId { get; set; }
    public Client Client { get; set; } = null!;

    public int CarId { get; set; }
    public Car Car { get; set; } = null!;
    public List<ServiceWork> ServiceWorks { get; set; } = [];
    public List<PartUsage> PartsUsed { get; set; } = [];

    public override string ToString() => $"Заказ #{Id}: {TotalCost:C}";
}
