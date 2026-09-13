using AutoServiceLab.Domain.Enums;

namespace AutoServiceLab.Domain.Entities;

public class Car
{
    public int Id { get; set; }
    public required string LicensePlate { get; set; }
    public required CarBrand Brand { get; set; }
    public required string Model { get; set; }
    public int Year { get; set; }
    public string? VinCode { get; set; }
    public string? Color { get; set; }
    public int? Mileage { get; set; }
    public CarType? Type { get; set; }
    public EngineType? EngineType { get; set; }
    public int? EngineVolume { get; set; }

    public int ClientId { get; set; }
    public Client Client { get; set; } = null!;

    public List<ServiceOrder> Orders { get; set; } = [];

    public override string ToString() => $"{Brand} {Model} ({Year})";
}
