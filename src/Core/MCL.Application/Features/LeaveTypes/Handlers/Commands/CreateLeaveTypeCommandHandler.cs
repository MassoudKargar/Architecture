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
        var leaveType = Mapper.Map<LeaveType>(request.LeaveTypeDto);
        leaveType = await Repository.AddAsync(leaveType, cancellationToken);
        return leaveType.Id;
    }
}

