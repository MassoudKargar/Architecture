   namespace MLC.Application.xUnitTest.Mocks;
public static class MockLeaveTypeRepository
{
    public static Mock<ILeaveTypeRepository>  GetLeaveTypeRepositoryMock()
    {
        var leaveTypes = new List<LeaveType>()
        {
            new()
            {
                Id = 1,
                DefaultDay = 10,
                Name = "Test Vacation"
            },
            new() 
            {
                Id = 2,
                DefaultDay = 15,
                Name = "Test Sick"
            }
        };
        var mockRepo = new Mock<ILeaveTypeRepository>();
        try
        {

            mockRepo.Setup(r => r.GetAllAsync(CancellationToken.None)).ReturnsAsync(leaveTypes);
             
            //mockRepo.Setup(r => r.AddAsync(It.IsAny<LeaveType>(), CancellationToken.None)) 
            //    .ReturnsAsync((LeaveType leaveType) =>
            //    {
            //        leaveTypes.Add(leaveType);
            //        return leaveType;
            //    });
        }
         catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        return mockRepo;
    }
}
