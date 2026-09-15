using AutoServiceLab.Domain.Enums;

namespace AutoServiceLab.Domain.Entities;

public class ServiceWork
{
    public int Id { get; set; }
    public required WorkType WorkType { get; set; }
    public string? Description { get; set; }
    public decimal LaborHours { get; set; }
    public decimal LaborCost { get; set; }
    public DateTime WorkDate { get; set; } = DateTime.Now;
    public bool IsWarranty { get; set; }
    public string? Notes { get; set; }

    public int ServiceOrderId { get; set; }
    public ServiceOrder ServiceOrder { get; set; } = null!;
    public int? MechanicId { get; set; }
    public Mechanic? Mechanic { get; set; } = null!;
}
