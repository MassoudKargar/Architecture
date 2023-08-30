namespace MCL.Application.Features.LeaveTypes.Requests.Commands;
public class CreateLeaveTypeCommand : IRequest<int>
{
    public LeaveTypeDto LeaveTypeDto { get; set; }
}

