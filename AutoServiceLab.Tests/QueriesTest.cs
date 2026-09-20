using AutoServiceLab.Domain.Enums;
using AutoServiceLab.Tests.Fixtures;

namespace AutoServiceLab.Tests;

/// <summary>
/// Набор тестов для проверки LINQ-запросов автосервиса
/// </summary>
public class QueriesTest(AutoServiceFixture fixture) : IClassFixture<AutoServiceFixture>
{
    /// <summary>
    /// Тест 1: Получение заказов в работе
    /// </summary>
    [Fact]
    public void GetOrdersInProgress_ReturnsOnlyInProgress()
    {
        var targetStatusId = OrderStatus.InProgress;
        var expectedOrderIds = new[] { 2, 7 };

        var resultOrders = fixture.ServiceOrders
            .Where(o => o.Status == targetStatusId)
            .Select(o => o.Id)
            .OrderBy(o => o)
            .ToList();

        Assert.NotEmpty(resultOrders);
        Assert.Equal(expectedOrderIds, resultOrders);
    }

    /// <summary>
    /// Тест 2: Получение топ 3 самых дорогих запчастей
    /// </summary>
    [Fact]
    public void GetTopExpensiveParts_ReturnsTopThree()
    {
        const int topCount = 3;
        var expectedPrices = new[] { 19000m, 8500m, 6000m };

        var resultPrices = fixture.Parts
            .OrderByDescending(p => p.SellingPrice)
            .Take(topCount)
            .Select(p => p.SellingPrice)
            .ToList();

        Assert.Equal(expectedPrices, resultPrices);
    }

    /// <summary>
    /// Тест 3: Получение клиентов с несколькими автомобилями
    /// </summary>
    [Fact]
    public void GetClientsWithMultipleCars_ReturnsOnlyMatching()
    {
        var expectedClientsId = new[] { 2 };

        var resultClientsId = fixture.Clients
            .Where(c => c.Cars.Count >= 2)
            .Select(c => c.Id)
            .OrderBy(id => id)
            .ToList();

        Assert.Equal(expectedClientsId, resultClientsId);
    }

    /// <summary>
    /// Тест 4: Получение автомобилей марки Toyota
    /// </summary>
    [Fact]
    public void GetCarsByBrand_ReturnsOnlyToyota()
    {
        var targetBrand = CarBrand.Toyota;
        var expectedCarsId = new[] { 1, 7 };

        var resultCarsId = fixture.Cars
            .Where(c => c.Brand == targetBrand)
            .Select(c => c.Id)
            .OrderBy(id => id)
            .ToList();

        Assert.Equal(expectedCarsId, resultCarsId);
    }

    /// <summary>
    /// Тест 5: Получение самого дорогого механика
    /// </summary>
    [Fact]
    public void GetMostExpensiveMechanic_ReturnsHighestRate()
    {
        var expectedName = "Егоров Михаил Валерьевич";
        var expectedHourlyRate = 3000m;

        var result = fixture.Mechanics
            .OrderByDescending(m => m.HourlyRate)
            .First();

        Assert.Equal(expectedName, result.FullName);
        Assert.Equal(expectedHourlyRate, result.HourlyRate);
    }

    /// <summary>
    /// Тест 6: Получение оплаченных счетов
    /// </summary>
    [Fact]
    public void GetPaidInvoices_ReturnsOnlyPaid()
    {
        var expectedInvoicesId = new[] { 1, 3, 5, 6 };

        var resultInvoicesId = fixture.Invoices
            .Where(i => i.PaymentStatus == PaymentStatus.Paid)
            .Select(i => i.Id)
            .OrderBy(id => id)
            .ToList();

        Assert.Equal(expectedInvoicesId, resultInvoicesId);
    }

    /// <summary>
    /// Тест 7: Получение работ типа «Замена масла»
    /// </summary>
    [Fact]
    public void GetWorksByType_ReturnsOnlyOilChange()
    {
        var targetType = WorkType.OilChange;
        var expectedWorkIds = new[] { 1, 8 };

        var resultWorkIds = fixture.ServiceWorks
            .Where(w => w.WorkType == targetType)
            .Select(w => w.Id)
            .OrderBy(id => id)
            .ToList();

        Assert.Equal(expectedWorkIds, resultWorkIds);
    }

    /// <summary>
    /// Тест 8: Получение использований конкретной запчасти
    /// </summary>
    [Fact]
    public void GetPartUsagesByPart_ReturnsOnlyForSpecificPart()
    {
        var targetPartId = 1;
        var expectedUsageIds = new[] { 1, 7 };

        var resultUsageIds = fixture.PartUsages
            .Where(u => u.PartId == targetPartId)
            .Select(u => u.Id)
            .OrderBy(id => id)
            .ToList();

        Assert.Equal(expectedUsageIds, resultUsageIds);
    }
}
