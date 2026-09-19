using AutoServiceLab.Domain.Enums;

namespace AutoServiceLab.Domain.Entities;

/// <summary>
/// Запчасть 
/// </summary>
public class Part
{
    /// <summary>
    /// Идентификатор запчасти
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Название запчасти
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// Артикул запчасти
    /// </summary>
    public required string PartNumber { get; set; }

    /// <summary>
    /// Категория запчасти
    /// </summary>
    public required PartCategory Category { get; set; }

    /// <summary>
    /// Производитель запчасти
    /// </summary>
    public string? Manufacturer { get; set; }

    /// <summary>
    /// Закупочная цена
    /// </summary>
    public decimal PurchasePrice { get; set; }

    /// <summary>
    /// Цена продажи
    /// </summary>
    public decimal SellingPrice { get; set; }

    /// <summary>
    /// Количество на складе
    /// </summary>
    public int QuantityInStock { get; set; }

    /// <summary>
    /// Статус запчасти
    /// </summary>
    public PartStatus Status { get; set; } = PartStatus.InStock;

    /// <summary>
    /// Использования запчасти
    /// </summary>
    public List<PartUsage> Usages { get; set; } = [];

    /// <summary>
    /// Возвращает строковое представление запчасти
    /// </summary>
    public override string ToString() => $"{Name} ({PartNumber})";
}
