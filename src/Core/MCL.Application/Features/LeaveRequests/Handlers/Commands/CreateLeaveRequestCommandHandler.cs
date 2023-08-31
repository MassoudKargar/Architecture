   namespace MCL.Application.Features.LeaveRequests.Handlers.Commands;
public class CreateLeaveRequestCommandHandler : IRequestHandler<CreateLeaveRequestCommand, BaseCommandResponse>
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
    public async Task<BaseCommandResponse> Handle(CreateLeaveRequestCommand request, CancellationToken cancellationToken)
    {
        var response = new BaseCommandResponse();
        #region Validator
        var validator = new CreateLeaveRequestDtoValidator(LeaveTypeRepository);
        var validationResult = await validator.ValidateAsync(request.CreateLeaveRequestDto, cancellationToken);
        if (validationResult.IsValid is false)
        {
            //throw new Exceptions.ValidationException(validationResult);
            response.Success = false;
            response.Message = "Creation Failed";
            response.Errors = validationResult.Errors.Select(s => s.ErrorMessage).ToList();
        }
        #endregion
        var leaveRequest = Mapper.Map<LeaveRequest>(request.CreateLeaveRequestDto );
        leaveRequest = await Repository.AddAsync(leaveRequest,cancellationToken);

        response.Success = true;
        response.Message = "Creation Successful";
        response.Id = leaveRequest.Id;

        return response;
    }
}
