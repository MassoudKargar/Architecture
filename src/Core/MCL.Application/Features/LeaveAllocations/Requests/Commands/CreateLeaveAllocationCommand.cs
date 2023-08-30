namespace MCL.Application.Features.LeaveAllocations.Requests.Commands;
public class CreateLeaveAllocationCommand : IRequest<LeaveAllocationDto>
{
    public LeaveAllocationDto LeaveAllocationDto { get; set; }
}
