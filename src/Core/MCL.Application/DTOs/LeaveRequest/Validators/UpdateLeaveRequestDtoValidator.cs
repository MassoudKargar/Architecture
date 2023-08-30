namespace MCL.Application.DTOs.LeaveRequest.Validators;
public class UpdateLeaveRequestDtoValidator : AbstractValidator<UpdateLeaveRequestDto>
{
    private ILeaveTypeRepository Repository { get; }

    public UpdateLeaveRequestDtoValidator(ILeaveTypeRepository repository)
    {
        Repository = repository;
        Include(new ILeaveRequestDtoValidator(Repository));
        RuleFor(p => p.Id)
            .NotNull().WithMessage("{PropertyName} is required.");
    }
}
