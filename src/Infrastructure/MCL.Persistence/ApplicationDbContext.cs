using MCL.Domain.Common;

namespace MCL.Persistence;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<LeaveRequest> LeaveRequests { get; set; }
    public DbSet<LeaveAllocation> LeaveAllocations { get; set; }
    public DbSet<LeaveType> LeaveTypes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
    }

    #region SaveChanges
    public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = new CancellationToken())
    {
        SaveChangesCustoms();
        return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
    }

    public override int SaveChanges()
    {
        SaveChangesCustoms();
        return base.SaveChanges();
    }

    public override int SaveChanges(bool acceptAllChangesOnSuccess)
    {
        SaveChangesCustoms();
        return base.SaveChanges(acceptAllChangesOnSuccess);
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
    {
        SaveChangesCustoms();
        return base.SaveChangesAsync(cancellationToken);
    }

    private void SaveChangesCustoms()
    {
        foreach (var entity in ChangeTracker.Entries<BaseDomainEntity>())
        {
            if (entity.State is EntityState.Added)
            {
                entity.Entity.DateCreated = DateTime.Now;
            }
            entity.Entity.LastModifiedDate = DateTime.Now;
        }
    }
    #endregion
}
