namespace MCL.Persistence.Repositories;
public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
{
    public LeaveTypeRepository(ApplicationDbContext context) : base(context)
    {
    }
}
