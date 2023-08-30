namespace MCL.Application.Persistence.Contracts;
public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
{
    Task<LeaveRequest> GetLeaveRequestWithDetailsAsync(int id, CancellationToken cancellationToken);
    Task<List<LeaveRequest>> GetLeaveRequestsWithDetailsAsync(CancellationToken cancellationToken);
}
