namespace AutoServiceLab.Domain.Entities;

/// <summary>
/// Клиент автосервиса
/// </summary>
public class Client
{
    /// <summary>
    /// Идентификатор клиента
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// ФИО клиента
    /// </summary>
    public required string FullName { get; set; }

    /// <summary>
    /// Номер телефона клиента
    /// </summary>
    public required string Phone { get; set; }

    /// <summary>
    /// Электронная почта клиента
    /// </summary>
    public string? Email { get; set; }

    /// <summary>
    /// Дата регистрации
    /// </summary>
    public DateTime RegistrationDate { get; set; } = DateTime.Now;

    /// <summary>
    /// Автомобили клиента
    /// </summary>
    public List<Car> Cars { get; set; } = [];

    /// <summary>
    /// Заказы клиента
    /// </summary>
    public List<ServiceOrder> Orders { get; set; } = [];

    /// <summary>
    /// Возвращает строковое представление клиента
    /// </summary>
    public override string ToString() => $"{FullName} ({Phone})";
}
