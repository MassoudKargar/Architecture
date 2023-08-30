namespace MCL.Application.Features.LeaveTypes.Requests.Queries;
public class GertLeaveTypeDetailRequest : IRequest<LeaveTypeDto>
{
    public int Id { get; set; }
}

