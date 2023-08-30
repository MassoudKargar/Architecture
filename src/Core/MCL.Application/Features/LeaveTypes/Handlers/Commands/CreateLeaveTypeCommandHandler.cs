namespace MCL.Application.Features.LeaveTypes.Handlers.Commands;
public class CreateLeaveTypeCommandHandler : IRequestHandler<CreateLeaveTypeCommand, int>
{
    public CreateLeaveTypeCommandHandler(IMapper mapper, ILeaveTypeRepository repository)
    {
        Mapper = mapper;
        Repository = repository;
    }

    private IMapper Mapper { get; }
    private ILeaveTypeRepository Repository { get; }

    public async Task<int> Handle(CreateLeaveTypeCommand request, CancellationToken cancellationToken)
    {
        #region Validator
        var validator = new CreateLeaveTypeValidator();
        var validationResult = await validator.ValidateAsync(request.CreateLeaveTypeDto, cancellationToken);
        if (validationResult.IsValid is false)
        {
            throw new Exception();
        }
        #endregion

        var leaveType = Mapper.Map<LeaveType>(request.CreateLeaveTypeDto);
        leaveType = await Repository.AddAsync(leaveType, cancellationToken);
        return leaveType.Id;

    }
}
