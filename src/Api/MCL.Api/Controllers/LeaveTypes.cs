namespace MCL.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LeaveTypes : ControllerBase
{
    public LeaveTypes(IMediator mediator)
    {
        Mediator = mediator;
    }

    private IMediator Mediator { get; }

    [HttpGet]
    public async Task<ActionResult<List<LeaveTypeDto>>> Get() =>
        Ok(await Mediator.Send(new GetLeaveTypeListRequest()));

    [HttpGet("{id:int}")]
    public async Task<ActionResult<LeaveTypeDto>> Get(int id) =>
        await Mediator.Send(new GetLeaveTypeDetailRequest() { Id = id });

    [HttpPost]
    public async Task<ActionResult<int>> Post([FromBody] CreateLeaveTypeDto dto) =>
        Ok(await Mediator.Send(new CreateLeaveTypeCommand()
        {
            CreateLeaveTypeDto = dto
        }));

    [HttpPut("{id:int}")]
    public async Task<ActionResult> Put(int id, [FromBody] LeaveTypeDto dto)
    {
        dto.Id = id;
        await Mediator.Send(new UpdateLeaveTypeCommand()
        {
            LeaveTypeDto = dto
        });
        return NoContent();
    }

    [HttpDelete("{id:int}")]
    public async Task<ActionResult> Delete(int id)
    {
        await Mediator.Send(new DeleteLeaveTypeCommand()
        {
            Id = id
        });
        return NoContent();
    }

}
