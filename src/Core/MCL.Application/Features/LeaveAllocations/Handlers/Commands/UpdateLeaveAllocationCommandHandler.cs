namespace MCL.Application.Features.LeaveAllocations.Handlers.Commands;
public class UpdateLeaveAllocationCommandHandler : IRequestHandler<UpdateLeaveAllocationCommand,Unit>
{
    public UpdateLeaveAllocationCommandHandler(ILeaveAllocationRepository repository, IMapper mapper)
    {
        Repository = repository;
        Mapper = mapper;
    }

    private ILeaveAllocationRepository Repository { get; }
    private IMapper Mapper { get; }
    public Task<Unit> Handle(UpdateLeaveAllocationCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
