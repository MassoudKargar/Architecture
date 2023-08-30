namespace MCL.Application.Features.LeaveTypes.Handlers.Commands;
public class UpdateLeaveTypeCommandHandler : IRequestHandler<UpdateLeaveTypeCommand,Unit>
{
    public UpdateLeaveTypeCommandHandler(ILeaveTypeRepository repository, IMapper mapper)
    {
        Repository = repository;
        Mapper = mapper;
    }

    private ILeaveTypeRepository Repository { get; }
    private IMapper Mapper { get; }

    public Task<Unit> Handle(UpdateLeaveTypeCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
