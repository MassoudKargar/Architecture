namespace MCL.Application.Features.LeaveTypes.Handlers.Commands;

public class DeleteLeaveTypeCommandHandler : IRequestHandler<DeleteLeaveTypeCommand,Unit>
{
    public DeleteLeaveTypeCommandHandler(ILeaveTypeRepository repository, IMapper mapper)
    {
        Repository = repository;
        Mapper = mapper;
    }

    private ILeaveTypeRepository Repository { get; }
    private IMapper Mapper { get; }
    public async Task<Unit> Handle(DeleteLeaveTypeCommand request, CancellationToken cancellationToken)
    {
        var leaveType = await Repository.GetAsync(request.Id, cancellationToken);
        if (leaveType is null) throw new Exceptions.NotFoundException(nameof(LeaveType), request.Id);
        await Repository.DeleteAsync(leaveType, cancellationToken);
        return Unit.Value;
    }
}

