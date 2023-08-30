namespace MCL.Application.Features.LeaveAllocations.Handlers.Commands;
public class CreateLeaveAllocationCommandHandler : IRequestHandler<CreateLeaveAllocationCommand,int>
{
    public CreateLeaveAllocationCommandHandler(ILeaveAllocationRepository repository, IMapper mapper)
    {
        Repository = repository;
        Mapper = mapper;
    }

    private ILeaveAllocationRepository Repository { get; }
    private IMapper Mapper { get; }

    public async Task<int> Handle(CreateLeaveAllocationCommand request, CancellationToken cancellationToken)
    {
        #region Validator
        var validator = new CreateLeaveAllocationDtoValidator(Repository);
        var validationResult = await validator.ValidateAsync(request.CreateLeaveAllocationDto, cancellationToken);
        if (validationResult.IsValid is false)
        {
            throw new Exception();
        }
        #endregion
        var leaveAllocation = Mapper.Map<LeaveAllocation>(request.CreateLeaveAllocationDto);
        leaveAllocation = await Repository.AddAsync(leaveAllocation,cancellationToken);
        return leaveAllocation.Id;
    }
}
