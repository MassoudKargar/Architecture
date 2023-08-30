namespace MCL.Application.Features.LeaveTypes.Handlers.Queries;

public class GetLeaveTypeListRequestHandler : IRequestHandler<GetLeaveTypeListRequest, List<LeaveTypeDto>>
{
    public GetLeaveTypeListRequestHandler(ILeaveTypeRepository repository, IMapper mapper)
    {
        Repository = repository;
        Mapper = mapper;
    }

    private ILeaveTypeRepository Repository { get; }
    private IMapper Mapper { get; }

    public async Task<List<LeaveTypeDto>> Handle(GetLeaveTypeListRequest request, CancellationToken cancellationToken) => 
        Mapper.Map<List<LeaveTypeDto>>(await Repository.GetAllAsync());
}
