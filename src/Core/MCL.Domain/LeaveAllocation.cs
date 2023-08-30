namespace MCL.Domain;
public class LeaveAllocation : BaseDomainEntity
{
    public int NumberOfDays { get; set; }
    public LeaveType LeaveType { get; set; }
    public int LeaveId { get; set; }
    public int Priod { get; set; }
}
