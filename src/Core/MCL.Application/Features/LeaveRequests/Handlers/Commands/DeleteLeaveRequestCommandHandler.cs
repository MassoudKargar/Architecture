namespace MCL.Application.Features.LeaveRequests.Handlers.Commands;
public class DeleteLeaveRequestCommandHandler : IRequestHandler<DeleteLeaveRequestCommand, Unit>
{
    public DeleteLeaveRequestCommandHandler(ILeaveRequestRepository repository)
    {
        Repository = repository;
    }

    private ILeaveRequestRepository Repository { get; }
    public async Task<Unit> Handle(DeleteLeaveRequestCommand request, CancellationToken cancellationToken)
    {
        var leaveRequest = await Repository.GetAsync(request.Id, cancellationToken);
        await Repository.DeleteAsync(leaveRequest, cancellationToken);
        return Unit.Value;
    }
}
