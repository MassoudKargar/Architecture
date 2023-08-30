namespace MCL.Application.Features.LeaveRequests.Handlers.Commands;
public class UpdateLeaveRequestCommandHandler : IRequestHandler<UpdateLeaveRequestCommand, Unit>
{
    public UpdateLeaveRequestCommandHandler(ILeaveRequestRepository repository, IMapper mapper)
    {
        Repository = repository;
        Mapper = mapper;
    }

    private ILeaveRequestRepository Repository { get; }
    private IMapper Mapper { get; }
    public Task<Unit> Handle(UpdateLeaveRequestCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
