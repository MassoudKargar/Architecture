namespace MCL.Application.Features.LeaveAllocations.Requests.Commands;
public class UpdateLeaveAllocationCommand : IRequest<Unit>
{
    public LeaveAllocationDto LeaveAllocationDto { get; set; }
}
