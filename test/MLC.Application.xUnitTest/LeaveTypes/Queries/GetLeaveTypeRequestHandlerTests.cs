namespace MLC.Application.xUnitTest.LeaveTypes.Queries;

public class GetLeaveTypeRequestHandlerTests
{
    IMapper _mapper;
    Mock<ILeaveTypeRepository> LeaveTypeRepository;
    public GetLeaveTypeRequestHandlerTests()
    {
        LeaveTypeRepository = MockLeaveTypeRepository.GetLeaveTypeRepositoryMock();
        var mapperConfig = new MapperConfiguration(m =>
        {
            m.AddProfile<MappingProfile>();
        });
        _mapper = mapperConfig.CreateMapper();
    }



    [Fact]
    public async Task GetLeaveTypeListTask()
    {
        var handler = new GetLeaveTypeListRequestHandler(LeaveTypeRepository.Object, _mapper);
        var result = await handler.Handle(new GetLeaveTypeListRequest(), CancellationToken.None);
        result.ShouldBeOfType<List<LeaveTypeDto>>();
        result.Count.ShouldBe(2);
    }
}
