namespace AutoServiceLab.Domain.Enums;

/// <summary>
/// Типы работ
/// </summary>
public enum WorkType
{
    /// <summary>
    /// Диагностика
    /// </summary>
    Diagnostics = 0,

    /// <summary>
    /// Замена масла
    /// </summary>
    OilChange = 1,

    /// <summary>
    /// Замена шин
    /// </summary>
    TireReplacement = 2,

    /// <summary>
    /// Ремонт тормозов
    /// </summary>
    BrakeRepair = 3,

    /// <summary>
    /// Ремонт двигателя
    /// </summary>
    EngineRepair = 4,

    /// <summary>
    /// Ремонт трансмиссии
    /// </summary>
    TransmissionRepair = 5,

    /// <summary>
    /// Ремонт электрики
    /// </summary>
    ElectricalRepair = 6,

    /// <summary>
    /// Кузовной ремонт
    /// </summary>
    BodyRepair = 7,

    /// <summary>
    /// Покраска
    /// </summary>
    Painting = 8
}
