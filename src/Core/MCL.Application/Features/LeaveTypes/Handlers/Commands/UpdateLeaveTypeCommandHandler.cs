namespace MCL.Application.Features.LeaveTypes.Handlers.Commands;
public class UpdateLeaveTypeCommandHandler : IRequestHandler<UpdateLeaveTypeCommand, Unit>
{
    public UpdateLeaveTypeCommandHandler(ILeaveTypeRepository repository, IMapper mapper)
    {
        Repository = repository;
        Mapper = mapper;
    }

    private ILeaveTypeRepository Repository { get; }
    private IMapper Mapper { get; }

    public async Task<Unit> Handle(UpdateLeaveTypeCommand request, CancellationToken cancellationToken)
    {
        var leaveType = await Repository.GetAsync(request.LeaveTypeDto.Id, cancellationToken);
        Mapper.Map(request.LeaveTypeDto, leaveType);
        await Repository.UpdateAsync(leaveType, cancellationToken);
        return Unit.Value;
    }
}
