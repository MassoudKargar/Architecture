namespace MCL.Application.DTOs.LeaveAllocation.Validators;
public class ILeaveAllocatorDtoValidator : AbstractValidator<ILeaveAllocationDto>
{
    private ILeaveAllocationRepository Repository { get; }

    public ILeaveAllocatorDtoValidator(ILeaveAllocationRepository repository)
    {
        Repository = repository;
        RuleFor(p => p.NumberOfDays)
            .GreaterThan(0).WithMessage("{PropertyName} must greater then {ComparisonValue}");
        RuleFor(p => p.Priod)
            .GreaterThanOrEqualTo(DateTime.Now.Year).WithMessage("{PropertyName} must greater then {ComparisonValue}");

        RuleFor(p => p.LeaveTypeId)
            .MustAsync(async (id, token) =>
            {
                var leaveTypExist = await repository.ExistAsync(id, token);
                return !leaveTypExist;
            })
            .GreaterThan(0).WithMessage("{PropertyName} dose not exist.");
    }
}
