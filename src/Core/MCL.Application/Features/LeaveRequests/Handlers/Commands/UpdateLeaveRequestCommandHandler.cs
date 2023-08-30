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
    public async Task<Unit> Handle(UpdateLeaveRequestCommand request, CancellationToken cancellationToken)
    {
            var leaveRequest = await Repository.GetAsync(request.Id, cancellationToken);
        if (request.UpdateLeaveRequestDto is not null)
        {
            Mapper.Map(request, leaveRequest);
            await Repository.UpdateAsync(leaveRequest, cancellationToken);
        } else if (request.ChangeLeaveRequestApprovalDto is not null)
        {
            await Repository.ChangeApprovalStatus(leaveRequest,request.ChangeLeaveRequestApprovalDto.Approved, cancellationToken);
        }

        return Unit.Value;
    }
}
