﻿namespace MCL.Application.Features.LeaveAllocations.Requests.Commands;
public class CreateLeaveAllocationCommand : IRequest<int>
{
    public CreateLeaveAllocationDto CreateLeaveAllocationDto { get; set; }
}
