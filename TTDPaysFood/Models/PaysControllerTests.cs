public class PaysControllerTests
{
    [Fact]
    public void GetPays_ReturnsAllPays()
    {
        // Arrange: Set up test data
        var controller = new PaysController();

        // Act: Invoke the API endpoint
        var result = controller.GetPays();

        // Assert: Verify the result
        Assert.IsType<ActionResult<IEnumerable<Pay>>>(result);
        // Check other assertions
    }

    // Write similar tests for other API endpoints
}
