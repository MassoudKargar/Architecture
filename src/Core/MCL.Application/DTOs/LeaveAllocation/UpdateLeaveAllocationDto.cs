 namespace MCL.Application.DTOs.LeaveAllocation;
public class UpdateLeaveAllocationDto : BaseDto, ILeaveAllocationDto
{
    public int NumberOfDays { get; set; }
    public int LeaveId { get; set; }
    public int Priod { get; set; }
}
