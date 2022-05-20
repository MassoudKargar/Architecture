namespace Solution.Application.GetUserById;

public class GetUserByIdRequestHandler : IRequestHandler<GetUserByIdRequest, GetUserByIdResponse>
{
    Task<GetUserByIdResponse> IRequestHandler<GetUserByIdRequest, GetUserByIdResponse>.Handle(GetUserByIdRequest request, CancellationToken cancellationToken) => 
        Task.FromResult(new GetUserByIdResponse(request.Id, "Masoud"));
}
