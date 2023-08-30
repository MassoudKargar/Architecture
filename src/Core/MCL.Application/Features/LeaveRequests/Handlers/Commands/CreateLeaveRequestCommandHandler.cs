namespace MCL.Application.Features.LeaveRequests.Handlers.Commands;
public class CreateLeaveRequestCommandHandler : IRequestHandler<CreateLeaveRequestCommand, int>
{
    public CreateLeaveRequestCommandHandler(ILeaveRequestRepository repository, IMapper mapper)
    {
        Repository = repository;
        Mapper = mapper;
    }

    private ILeaveRequestRepository Repository { get; }
    private IMapper Mapper { get; }
    public async Task<int> Handle(CreateLeaveRequestCommand request, CancellationToken cancellationToken)
    {
        var leaveRequest = Mapper.Map<LeaveRequest>(request.LeaveRequestDto);
        leaveRequest = await Repository.AddAsync(leaveRequest,cancellationToken);
        return leaveRequest.Id;
    }
}
