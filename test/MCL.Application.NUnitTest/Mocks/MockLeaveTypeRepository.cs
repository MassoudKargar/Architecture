namespace MCL.Application.NUnitTest.Mocks;
public static class MockLeaveTypeRepository
{
    public static Mock<ILeaveTypeRepository> GetLeaveTypeRepositoryMock()
    {
        var leaveTypes = new List<LeaveType>()
        {
            new LeaveType()
            {
                Id = 1,
                DefaultDay = 10,
                Name = "Test Vacation"
            },
            new LeaveType()
            {
                Id = 2,
                DefaultDay = 15,
                Name = "Test Sick"
            }
        };
        var mockRepo = new Mock<ILeaveTypeRepository>(); 
        mockRepo.Setup(r => r.GetAllAsync(CancellationToken.None)).ReturnsAsync(leaveTypes);
        mockRepo.Setup(r => r.AddAsync(It.IsAny<LeaveType>(), CancellationToken.None))
            .ReturnsAsync((LeaveType leaveType) =>
            {
                leaveTypes.Add(leaveType);
                return leaveType;
            });
        return mockRepo;
    }
}
