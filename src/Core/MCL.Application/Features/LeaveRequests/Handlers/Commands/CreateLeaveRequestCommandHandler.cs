namespace MCL.Application.Features.LeaveRequests.Handlers.Commands;
public class CreateLeaveRequestCommandHandler : IRequestHandler<CreateLeaveRequestCommand, int>
{
    public CreateLeaveRequestCommandHandler(ILeaveRequestRepository repository, IMapper mapper, ILeaveTypeRepository leaveTypeRepository)
    {
        Repository = repository;
        Mapper = mapper;
        LeaveTypeRepository = leaveTypeRepository;
    }

    private ILeaveRequestRepository Repository { get; }
    private ILeaveTypeRepository LeaveTypeRepository { get; }
    private IMapper Mapper { get; }
    public async Task<int> Handle(CreateLeaveRequestCommand request, CancellationToken cancellationToken)
    {
        #region Validator
        var validator = new CreateLeaveRequestDtoValidator(LeaveTypeRepository);
        var validationResult = await validator.ValidateAsync(request.CreateLeaveRequestDto, cancellationToken);
        if (validationResult.IsValid is false)
        {
            throw new Exception();
        }
        #endregion
        var leaveRequest = Mapper.Map<LeaveRequest>(request.CreateLeaveRequestDto );
        leaveRequest = await Repository.AddAsync(leaveRequest,cancellationToken);
        return leaveRequest.Id;
    }
}
