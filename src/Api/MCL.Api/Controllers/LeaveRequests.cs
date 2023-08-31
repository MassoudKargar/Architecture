namespace MCL.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LeaveRequests : ControllerBase
{
    private IMediator Mediator { get; }

    [HttpGet]
    public async Task<ActionResult<List<LeaveRequestDto>>> Get() =>
        Ok(await Mediator.Send(new GetLeaveRequestListRequest()));

    [HttpGet("{id:int}")]
    public async Task<ActionResult<LeaveRequestDto>> Get(int id) =>
        await Mediator.Send(new GetLeaveRequestDetailRequest() { Id = id });
     
    [HttpPost]
    public async Task<ActionResult<int>> Post([FromBody] CreateLeaveRequestDto dto) =>
        Ok(await Mediator.Send(new CreateLeaveRequestCommand()
        {
            CreateLeaveRequestDto = dto
        }));

    [HttpPut("{id:int}")]
    public async Task<ActionResult> Put(int id, [FromBody] UpdateLeaveRequestDto dto)
    {
        await Mediator.Send(new UpdateLeaveRequestCommand()
        {
            Id = id,
            UpdateLeaveRequestDto = dto
        });
        return NoContent();
    }

    [HttpDelete("{id:int}")]
    public async Task<ActionResult> Delete(int id)
    {
        await Mediator.Send(new DeleteLeaveRequestCommand()
        {
            Id = id
        });
        return NoContent();
    }

    [HttpPut("changeApproval/{id:int}")]
    public async Task<ActionResult> ChangeApproval(int id, [FromBody] ChangeLeaveRequestApprovalDto dto)
    {
        await Mediator.Send(new UpdateLeaveRequestCommand()
        {
            Id = id,
            ChangeLeaveRequestApprovalDto = dto
        });
        return NoContent();
    }
}
    