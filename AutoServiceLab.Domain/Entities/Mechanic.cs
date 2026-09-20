namespace AutoServiceLab.Domain.Entities;

/// <summary>
/// Механик автосервиса
/// </summary>
public class Mechanic
{
    /// <summary>
    /// Идентификатор механика
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// ФИО механика
    /// </summary>
    public required string FullName { get; set; }

    /// <summary>
    /// Номер телефона механика
    /// </summary>
    public required string Phone { get; set; }

    /// <summary>
    /// Специализация механика
    /// </summary>
    public required string Specialization { get; set; }

    /// <summary>
    /// Опыт работы в годах
    /// </summary>
    public int ExperienceYears { get; set; }

    /// <summary>
    /// Почасовая ставка
    /// </summary>
    public decimal HourlyRate { get; set; }

    /// <summary>
    /// Доступность механика
    /// </summary>
    public bool IsAvailable { get; set; }

    /// <summary>
    /// Дата приёма на работу
    /// </summary>
    public DateTime HireDate { get; set; } = DateTime.Now;

    /// <summary>
    /// Работы механика
    /// </summary>
    public List<ServiceWork> Works { get; set; } = [];

    /// <summary>
    /// Возвращает строковое представление механика
    /// </summary>
    public override string ToString() => $"{FullName} ({Specialization})";
}
