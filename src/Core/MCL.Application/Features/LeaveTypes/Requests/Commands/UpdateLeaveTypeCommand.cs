﻿namespace MCL.Application.Features.LeaveTypes.Requests.Commands;
public class UpdateLeaveTypeCommand : IRequest<Unit>
{
    public LeaveTypeDto LeaveTypeDto { get; set; }
}
