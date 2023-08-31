namespace MCL.Persistence.Repositories;
public class LeaveRequestRepository : GenericRepository<LeaveRequest>, ILeaveRequestRepository
{
    private ApplicationDbContext Context { get; }

    public LeaveRequestRepository(ApplicationDbContext context) : base(context)
    {
        Context = context;
    }

    public async Task<LeaveRequest> GetLeaveRequestWithDetailsAsync(int id, CancellationToken cancellationToken)
    {
        return await Context.LeaveRequests.Include(t => t.LeaveType).FirstOrDefaultAsync(l => l.Id == id,cancellationToken);
    }

    public async Task<List<LeaveRequest>> GetLeaveRequestsWithDetailsAsync(CancellationToken cancellationToken)
    {
        return await Context.LeaveRequests.Include(t => t.LeaveType).ToListAsync(cancellationToken);
    }

    public async Task ChangeApprovalStatus(LeaveRequest leaveRequest, bool? approved, CancellationToken cancellationToken)
    {
        leaveRequest.Approved = approved;
        Context.Entry(leaveRequest).State = EntityState.Modified;
        await Context.SaveChangesAsync(cancellationToken);
    }
}
