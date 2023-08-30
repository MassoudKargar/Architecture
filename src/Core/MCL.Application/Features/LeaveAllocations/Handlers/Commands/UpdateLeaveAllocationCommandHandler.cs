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
    public async Task<Unit> Handle(UpdateLeaveAllocationCommand request, CancellationToken cancellationToken)
    {
        var leaveAllocation = await Repository.GetAsync(request.LeaveAllocationDto.Id, cancellationToken);
        Mapper.Map(request.LeaveAllocationDto, leaveAllocation);
        await Repository.UpdateAsync(leaveAllocation, cancellationToken);
        return Unit.Value;
    }
}
