﻿namespace MCL.Application.DTOs.LeaveRequest;
public class LeaveRequestListDto : BaseDto
{
    public LeaveTypeDto LeaveType { get; set; }
    public DateTime DateRequested { get; set; }
    public bool? Aoorived { get; set; }
}