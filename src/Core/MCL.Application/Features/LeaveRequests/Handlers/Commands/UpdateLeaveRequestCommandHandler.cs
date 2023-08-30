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
        var leaveRequest = await Repository.GetAsync(request.LeaveRequestDto.Id, cancellationToken);
        Mapper.Map(request.LeaveRequestDto, leaveRequest);
        await Repository.UpdateAsync(leaveRequest, cancellationToken);
        return Unit.Value;
    }
}
