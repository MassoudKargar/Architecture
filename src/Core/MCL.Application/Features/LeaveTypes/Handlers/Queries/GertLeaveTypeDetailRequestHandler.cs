namespace MCL.Application.Features.LeaveTypes.Handlers.Queries;
public class GertLeaveTypeDetailRequestHandler : IRequestHandler<GertLeaveTypeDetailRequest,LeaveTypeDto>
{
    public GertLeaveTypeDetailRequestHandler(ILeaveTypeRepository repository, IMapper mapper)
    {
        Repository = repository;
        Mapper = mapper;
    }

    private ILeaveTypeRepository Repository { get; }
    private IMapper Mapper { get; }

    public async Task<LeaveTypeDto> Handle(GertLeaveTypeDetailRequest request, CancellationToken cancellationToken) => 
        Mapper.Map<LeaveTypeDto>(await Repository.GetAsync(request.Id,cancellationToken));
}

