namespace MCL.Application.DTOs.LeaveRequest.Validators;
public class CreateLeaveRequestDtoValidator : AbstractValidator<CreateLeaveRequestsDto>
{
    private ILeaveRequestRepository Repository { get; }
    public CreateLeaveRequestDtoValidator(ILeaveRequestRepository repository)
    {
        Repository = repository;
        RuleFor(p => p.StartDate)
            .LessThan(c => c.EndDate).WithMessage("{PropertyName} must be before {ComparisonValue}");

        RuleFor(p => p.EndDate)
            .GreaterThan(c => c.StartDate).WithMessage("{PropertyName} must be after {ComparisonValue}");

        RuleFor(p => p.LeaveTypeId)
            .MustAsync(async (id, token) =>
            {
                var leaveTypExist = await repository.ExistAsync(id, token);
                return !leaveTypExist;
            })
            .GreaterThan(0).WithMessage("{PropertyName} dose not exist.");
    }
}
