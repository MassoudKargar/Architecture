namespace MCL.Application.DTOs.LeaveRequest.Validators;
public class UpdateLeaveRequestDtoValidator : AbstractValidator<UpdateLeaveRequestDto>
{
    private ILeaveRequestRepository Repository { get; }

    public UpdateLeaveRequestDtoValidator(ILeaveRequestRepository repository)
    {
        Repository = repository;
        Include(new ILeaveRequestDtoValidator(Repository));
        RuleFor(p => p.Id)
            .NotNull().WithMessage("{PropertyName} is required.");
    }
}
