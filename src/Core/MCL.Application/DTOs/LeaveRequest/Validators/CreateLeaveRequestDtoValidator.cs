namespace MCL.Application.DTOs.LeaveRequest.Validators;
public class CreateLeaveRequestDtoValidator : AbstractValidator<CreateLeaveRequestsDto>
{
    private ILeaveRequestRepository Repository { get; }
    public CreateLeaveRequestDtoValidator(ILeaveRequestRepository repository)
    {
        Repository = repository;
        Include(new ILeaveRequestDtoValidator(Repository));
    }
}
