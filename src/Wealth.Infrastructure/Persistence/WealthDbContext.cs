using Microsoft.EntityFrameworkCore;
using Wealth.Domain;

namespace Wealth.Infrastructure.Persistence;

public sealed class WealthDbContext(DbContextOptions<WealthDbContext> options)
    : DbContext(options)
{
    public DbSet<Portfolio> Portfolios => Set<Portfolio>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(
            typeof(WealthDbContext).Assembly);
    }
}