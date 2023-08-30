namespace MCL.Application.Features.LeaveAllocations.Requests.Commands;
public class UpdateLeaveAllocationCommand : IRequest<Unit>
{
    public UpdateLeaveAllocationDto UpdateLeaveAllocationDto { get; set; }
}
