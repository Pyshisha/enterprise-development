namespace AutoServiceLab.Domain.Enums;

public enum OrderStatus
{
    Created = 0,
    Confirmed = 1,
    InProgress = 2,
    WaitingParts = 3,
    Completed = 4,
    Cancelled = 5
}
