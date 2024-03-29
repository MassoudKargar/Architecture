﻿namespace MCL.Application.Features.LeaveAllocations.Handlers.Queries;
public class GertLeaveAllocationDetailRequestHandler : IRequestHandler<GetLeaveAllocationDetailRequest, LeaveAllocationDto>
{
    public GertLeaveAllocationDetailRequestHandler(ILeaveAllocationRepository repository, IMapper mapper)
    {
        Repository = repository;
        Mapper = mapper;
    }

    private ILeaveAllocationRepository Repository { get; }
    private IMapper Mapper { get; }

    public async Task<LeaveAllocationDto> Handle(GetLeaveAllocationDetailRequest request, CancellationToken cancellationToken) => 
        Mapper.Map<LeaveAllocationDto>(await Repository.GetLeaveAllocationWithDetails(request.Id,cancellationToken));
}

