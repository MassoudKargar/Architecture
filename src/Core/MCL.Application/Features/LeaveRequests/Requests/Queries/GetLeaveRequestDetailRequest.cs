namespace MCL.Application.Features.LeaveRequests.Requests.Queries;
public class GetLeaveRequestDetailRequest : IRequest<LeaveRequestDto>
{
    public int Id { get; set; }
}
