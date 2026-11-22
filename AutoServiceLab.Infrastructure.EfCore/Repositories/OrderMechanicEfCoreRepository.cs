using AutoServiceLab.Domain.Entities;
using AutoServiceLab.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace AutoServiceLab.Infrastructure.EfCore.Repositories;

/// <summary>
/// Репозиторий связей заказов и механиков (EF Core)
/// </summary>
public class OrderMechanicEfCoreRepository(AutoServiceDbContext context) : IOrderMechanicRepository
{
    /// <inheritdoc />
    public async Task<OrderMechanic?> GetAsync(int id) =>
        await context.OrderMechanics
        .Include(om => om.Mechanic)
        .FirstOrDefaultAsync(om => om.Id == id);

    /// <inheritdoc />
    public async Task<IReadOnlyList<OrderMechanic>> GetAllAsync() => 
        await context.OrderMechanics
        .Include(om => om.Mechanic)
        .ToListAsync();

    /// <inheritdoc />
    public async Task AddAsync(OrderMechanic entity)
    {
        await context.OrderMechanics.AddAsync(entity);
        await context.SaveChangesAsync();
    }

    /// <inheritdoc />
    public async Task UpdateAsync(OrderMechanic entity)
    {
        context.OrderMechanics.Update(entity);
        await context.SaveChangesAsync();
    }

    /// <inheritdoc />
    public async Task<bool> DeleteAsync(int id)
    {
        var entity = await GetAsync(id);
        if (entity == null) return false;

        context.OrderMechanics.Remove(entity);
        await context.SaveChangesAsync();
        return true;
    }
}