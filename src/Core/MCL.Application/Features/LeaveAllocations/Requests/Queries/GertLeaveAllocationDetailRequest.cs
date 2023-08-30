using MCL.Application.DTOs.LeaveAllocation;

namespace MCL.Application.Features.LeaveAllocations.Requests.Queries;
public class GertLeaveAllocationDetailRequest : IRequest<LeaveAllocationDto>
{
    public int Id { get; set; }
}

