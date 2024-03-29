﻿using MCL.Domain;

namespace MCL.Application.Features.LeaveAllocations.Handlers.Commands;
public class DeleteLeaveAllocationCommandHandler : IRequestHandler<DeleteLeaveAllocationCommand, Unit>
{
    public DeleteLeaveAllocationCommandHandler(ILeaveAllocationRepository repository)
    {
        Repository = repository;
    }

    private ILeaveAllocationRepository Repository { get; }
    public async Task<Unit> Handle(DeleteLeaveAllocationCommand request, CancellationToken cancellationToken)
    {
        var leaveAllocation = await Repository.GetAsync(request.Id, cancellationToken);
        if (leaveAllocation is null) throw new Exceptions.NotFoundException(nameof(LeaveAllocation), request.Id);
        await Repository.DeleteAsync(leaveAllocation, cancellationToken);
        return Unit.Value;
    }
}