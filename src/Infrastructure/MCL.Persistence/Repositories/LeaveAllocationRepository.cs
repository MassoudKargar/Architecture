namespace MCL.Persistence.Repositories;
public class LeaveAllocationRepository : GenericRepository<LeaveAllocation>, ILeaveAllocationRepository
{
    private ApplicationDbContext Context { get; }

    public LeaveAllocationRepository(ApplicationDbContext context) : base(context)
    {
        Context = context;
    }

    public async Task<LeaveAllocation> GetLeaveAllocationWithDetails(int id, CancellationToken cancellationToken)
    {
        return await Context.LeaveAllocations.Include(t => t.LeaveType).FirstOrDefaultAsync(f => f.Id == id,cancellationToken);
    }

    public async Task<List<LeaveAllocation>> GetLeaveAllocationsWithDetails(CancellationToken cancellationToken)
    {
        return await Context.LeaveAllocations.Include(t => t.LeaveType).ToListAsync(cancellationToken);
    }
}
