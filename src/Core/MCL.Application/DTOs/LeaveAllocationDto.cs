namespace MCL.Application.DTOs;
public class LeaveAllocationDto : BaseDto
{
    public int NumberOfDays { get; set; }
    public LeaveTypeDto LeaveType { get; set; }
    public int LeaveId { get; set; }
    public int Priod { get; set; }
}
