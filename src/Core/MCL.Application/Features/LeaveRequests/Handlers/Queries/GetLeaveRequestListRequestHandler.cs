namespace MCL.Application.Features.LeaveRequests.Handlers.Queries;
public class GetLeaveRequestListRequestHandler : IRequestHandler<GetLeaveRequestListRequest,List<LeaveRequestListDto>>
{
    public GetLeaveRequestListRequestHandler(ILeaveRequestRepository repository, IMapper mapper)
    {
        Repository = repository;
        Mapper = mapper;
    }
    private IMapper Mapper { get; }
    private ILeaveRequestRepository Repository { get; }
    public async Task<List<LeaveRequestListDto>> Handle(GetLeaveRequestListRequest request, CancellationToken cancellationToken) =>
        Mapper.Map<List<LeaveRequestListDto>>(await Repository.GetLeaveRequestsWithDetailsAsync());
}
