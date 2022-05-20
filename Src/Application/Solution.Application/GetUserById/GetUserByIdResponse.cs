namespace Solution.Application.GetUserById;

public class GetUserByIdResponse
{
    public GetUserByIdResponse(int id,string name)
    {
        Name = name;
        Id = id;
    }
    public int Id { get; set; }
    public string Name { get; set; }
}
