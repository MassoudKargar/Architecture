﻿namespace MCL.Application.DTOs.LeaveType;
public class LeaveTypeDto : BaseDto,ILeaveTypeDto
{
    public string Name { get; set; }
    public int DefaultDay { get; set; }
}

