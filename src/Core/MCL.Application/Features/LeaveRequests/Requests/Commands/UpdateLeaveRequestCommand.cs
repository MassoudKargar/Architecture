namespace MCL.Application.Features.LeaveRequests.Requests.Commands;
public class UpdateLeaveRequestCommand : IRequest<Unit>
{
    public LeaveRequestDto LeaveRequestDto { get; set; }
}
