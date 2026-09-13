using AutoServiceLab.Domain.Enums;

namespace AutoServiceLab.Domain.Entities;

public class Part
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string PartNumber { get; set; }
    public required PartCategory Category { get; set; }
    public string? Manufacturer { get; set; }
    public decimal PurchasePrice { get; set; }
    public decimal SellingPrice { get; set; }
    public int QuantityInStock { get; set; }
    public int MinStockQuantity { get; set; }
    public PartStatus Status { get; set; } = PartStatus.InStock;

    public List<PartUsage> Usages { get; set; } = [];

    public override string ToString() => $"{Name} ({PartNumber})";
}
