﻿namespace MCL.Application.DTOs.LeaveAllocation;
public class CreateLeaveAllocationDto : BaseDto, ILeaveAllocationDto
{
    public int NumberOfDays { get; set; }
    public int LeaveTypeId { get; set; }
    public int Priod { get; set; }
}

