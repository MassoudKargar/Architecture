namespace MCL.Application.Features.LeaveAllocations.Handlers.Commands;
public class UpdateLeaveAllocationCommandHandler : IRequestHandler<UpdateLeaveAllocationCommand, Unit>
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
        #region Validator
        var validator = new UpdateLeaveAllocationDtoValidator(Repository);
        var validationResult = await validator.ValidateAsync(request.UpdateLeaveAllocationDto, cancellationToken);
        if (validationResult.IsValid is false)
        {
            throw new Exceptions.ValidationException(validationResult);
        }
        #endregion
        var leaveAllocation = await Repository.GetAsync(request.UpdateLeaveAllocationDto.Id, cancellationToken);
        Mapper.Map(request.UpdateLeaveAllocationDto, leaveAllocation);
        await Repository.UpdateAsync(leaveAllocation, cancellationToken);
        return Unit.Value;
    }
}
