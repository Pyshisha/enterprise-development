namespace AutoServiceLab.Domain.Entities;

public class Mechanic
{
    public int Id { get; set; }
    public required string FullName { get; set; }
    public required string Phone { get; set; }
    public required string Specialization { get; set; }
    public int ExperienceYears { get; set; }
    public decimal HourlyRate { get; set; }
    public bool IsAvailable { get; set; }
    public DateTime HireDate { get; set; } = DateTime.Now;

    public List<ServiceOrder> Orders { get; set; } = [];
    public List<ServiceWork> Works { get; set; } = [];

    public override string ToString() => $"{FullName} ({Specialization})";
}
