namespace MCL.Application.Features.LeaveAllocations.Handlers.Commands;
public class CreateLeaveAllocationCommandHandler : IRequestHandler<CreateLeaveRequestCommand,int>
{
    public CreateLeaveAllocationCommandHandler(ILeaveAllocationRepository repository, IMapper mapper)
    {
        Repository = repository;
        Mapper = mapper;
    }

    private ILeaveAllocationRepository Repository { get; }
    private IMapper Mapper { get; }

    public async Task<int> Handle(CreateLeaveRequestCommand request, CancellationToken cancellationToken)
    {
        var leaveAllocation = Mapper.Map<LeaveAllocation>(request.LeaveRequestDto);
        leaveAllocation = await Repository.AddAsync(leaveAllocation,cancellationToken);
        return leaveAllocation.Id;
    }
}
