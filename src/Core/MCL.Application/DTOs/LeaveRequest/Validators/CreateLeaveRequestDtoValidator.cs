namespace MCL.Application.DTOs.LeaveRequest.Validators;
public class CreateLeaveRequestDtoValidator : AbstractValidator<CreateLeaveRequestDto>
{
    private ILeaveTypeRepository Repository { get; }
    public CreateLeaveRequestDtoValidator(ILeaveTypeRepository repository)
    {
        Repository = repository;
        Include(new ILeaveRequestDtoValidator(Repository));
    }
}
