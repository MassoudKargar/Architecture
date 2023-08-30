using MCL.Domain.Common;

namespace MCL.Domain;
public class LeaveType : BaseDomainEntity
{
    public string Name { get; set; }
    public int DefaultDay { get; set; }
}

