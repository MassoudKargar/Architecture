namespace MCL.Application.DTOs.LeaveAllocation.Validators;
public class CreateLeaveAllocationDtoValidator : AbstractValidator<CreateLeaveAllocationDto>
{
    private ILeaveAllocationRepository Repository { get; }

    public CreateLeaveAllocationDtoValidator(ILeaveAllocationRepository repository)
    {
        Repository = repository;
        Include(new ILeaveAllocatorDtoValidator(Repository));
    }
}
