namespace MCL.Application.DTOs.LeaveType.Validators;
public class CreateLeaveTypeValidator : AbstractValidator<CreateLeaveTypeDto>
{
    public CreateLeaveTypeValidator()
    {
        Include(new ILeaveTypeDtoValidator());
    }
}
