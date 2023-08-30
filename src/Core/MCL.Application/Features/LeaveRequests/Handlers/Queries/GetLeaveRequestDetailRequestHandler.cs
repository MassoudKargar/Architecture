namespace MCL.Application.Features.LeaveRequests.Handlers.Queries;
public class GetLeaveRequestDetailRequestHandler : IRequestHandler<GetLeaveRequestDetailRequest,LeaveRequestDto>
{
    public GetLeaveRequestDetailRequestHandler(IMapper mapper, ILeaveRequestRepository repository)
    {
        Mapper = mapper;
        Repository = repository;
    }

    private ILeaveRequestRepository Repository { get; }
    private IMapper Mapper { get; }

    public async Task<LeaveRequestDto> Handle(GetLeaveRequestDetailRequest request, CancellationToken cancellationToken) =>
        Mapper.Map<LeaveRequestDto>(Repository.GetLeaveRequestWithDetailsAsync(request.Id,cancellationToken));
}