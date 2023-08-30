namespace MCL.Application.Features.LeaveAllocations.Handlers.Queries;

public class GetLeaveAllocationListRequestHandler : IRequestHandler<GetLeaveAllocationListRequest, List<LeaveAllocationDto>>
{
    public GetLeaveAllocationListRequestHandler(ILeaveAllocationRepository repository, IMapper mapper)
    {
        Repository = repository;
        Mapper = mapper;
    }

    private ILeaveAllocationRepository Repository { get; }
    private IMapper Mapper { get; }

    public async Task<List<LeaveAllocationDto>> Handle(GetLeaveAllocationListRequest request, CancellationToken cancellationToken) => 
        Mapper.Map<List<LeaveAllocationDto>>(await Repository.GetLeaveAllocationsWithDetails());
}
