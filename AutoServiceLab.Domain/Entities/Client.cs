namespace AutoServiceLab.Domain.Entities;

public class Client
{
    public int Id { get; set; }
    public required string FullName { get; set; }
    public required string Phone { get; set; }
    public string? Email { get; set; }
    public string? Address { get; set; }
    public DateTime RegistrationDate { get; set; } = DateTime.Now;

    public List<Car> Cars { get; set; } = [];
    public List<ServiceOrder> Orders { get; set; } = [];

    public override string ToString() => $"{FullName} ({Phone})";

}
