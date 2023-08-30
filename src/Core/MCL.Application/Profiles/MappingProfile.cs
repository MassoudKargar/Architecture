namespace MCL.Application.Profiles;
public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<LeaveType,LeaveTypeDto>().ReverseMap();
        CreateMap<LeaveRequest,LeaveRequestDto>().ReverseMap();
        CreateMap<LeaveRequest,LeaveRequestListDto>().ReverseMap();
        CreateMap<LeaveAllocation,LeaveAllocationDto>().ReverseMap();
    }
}
