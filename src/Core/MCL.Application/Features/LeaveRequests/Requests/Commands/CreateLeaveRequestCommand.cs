namespace MCL.Application.Features.LeaveRequests.Requests.Commands;
public class CreateLeaveRequestCommand : IRequest<int>
{
    public LeaveRequestDto LeaveRequestDto { get; set; }
}
