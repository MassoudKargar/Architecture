namespace MCL.Application.Contracts.Persistence;
public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
{
    Task<LeaveRequest> GetLeaveRequestWithDetailsAsync(int id, CancellationToken cancellationToken);
    Task<List<LeaveRequest>> GetLeaveRequestsWithDetailsAsync(CancellationToken cancellationToken);
    Task ChangeApprovalStatus(LeaveRequest leaveRequest, bool? approved, CancellationToken cancellationToken);
}
