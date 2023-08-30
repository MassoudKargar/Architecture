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
        #region Validator
        var validator = new UpdateLeaveTypeValidator();
        var validationResult = await validator.ValidateAsync(request.LeaveTypeDto, cancellationToken);
        if (validationResult.IsValid is false)
        {
            throw new Exceptions.ValidationException(validationResult);
        }
        #endregion
        var leaveType = await Repository.GetAsync(request.LeaveTypeDto.Id, cancellationToken);
        Mapper.Map(request.LeaveTypeDto, leaveType);
        await Repository.UpdateAsync(leaveType, cancellationToken);
        return Unit.Value;
    }
}
