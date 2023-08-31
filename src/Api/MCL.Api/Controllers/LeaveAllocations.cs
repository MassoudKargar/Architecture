using MCL.Application.DTOs.LeaveAllocation;
using MCL.Application.Features.LeaveAllocations.Requests.Commands;
using MCL.Application.Features.LeaveAllocations.Requests.Queries;

namespace MCL.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class LeaveAllocations : Controller
{
    private IMediator Mediator { get; }

    [HttpGet]
    public async Task<ActionResult<List<LeaveAllocationDto>>> Get() =>
        Ok(await Mediator.Send(new GetLeaveAllocationListRequest()));

    [HttpGet("{id:int}")]
    public async Task<ActionResult<LeaveAllocationDto>> Get(int id) =>
        await Mediator.Send(new GetLeaveAllocationDetailRequest { Id = id });

    [HttpPost]
    public async Task<ActionResult<int>> Post([FromBody] CreateLeaveAllocationDto dto) =>
        Ok(await Mediator.Send(new CreateLeaveAllocationCommand()
        {
             CreateLeaveAllocationDto = dto
        }));

    [HttpPut("{id:int}")]
    public async Task<ActionResult> Put(int id, [FromBody] UpdateLeaveAllocationDto dto)
    {
        await Mediator.Send(new UpdateLeaveAllocationCommand()
        {
            UpdateLeaveAllocationDto = dto
        });
        return NoContent();
    }

    [HttpDelete("{id:int}")]
    public async Task<ActionResult> Delete(int id)
    {
        await Mediator.Send(new DeleteLeaveAllocationCommand()
        {
            Id = id
        });
        return NoContent();
    }
}
