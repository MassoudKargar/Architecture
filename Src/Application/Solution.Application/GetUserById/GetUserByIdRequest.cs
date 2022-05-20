namespace Solution.Application.GetUserById;

public class GetUserByIdRequest : IRequest<GetUserByIdResponse>
{
    public int Id { get; set; }
}