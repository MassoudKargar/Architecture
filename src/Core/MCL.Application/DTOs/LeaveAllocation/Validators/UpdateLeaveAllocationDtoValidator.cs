namespace MCL.Application.DTOs.LeaveAllocation.Validators;
public class UpdateLeaveAllocationDtoValidator : AbstractValidator<UpdateLeaveAllocationDto>
{
    private ILeaveAllocationRepository Repository { get; }

    public UpdateLeaveAllocationDtoValidator(ILeaveAllocationRepository repository)
    {
        Repository = repository;
        Include(new ILeaveAllocatorDtoValidator(Repository));
        RuleFor(p => p.Id)
            .NotNull().WithMessage("{PropertyName} is required.");
    }
}
