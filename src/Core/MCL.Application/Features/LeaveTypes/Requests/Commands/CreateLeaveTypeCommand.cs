namespace MCL.Application.Features.LeaveTypes.Requests.Commands;
public class CreateLeaveTypeCommand : IRequest<int>
{
    public CreateLeaveTypeDto CreateLeaveTypeDto { get; set; }
}

