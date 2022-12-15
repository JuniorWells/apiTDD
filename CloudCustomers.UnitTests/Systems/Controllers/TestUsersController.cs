using CloudCustomers.API.Controllers;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;

namespace CloudCustomers.UnitTests;

public class UnitTest1
{
    [Fact]
    public async Task Get_OnSuccess_ReturnStatusCode200()
    {
		// Arrange
		var sut = new UsersController();

		// Act
		var result = (OkObjectResult)await sut.Get();
		
		// Assert
		result.StatusCode.Should().Be(200);
    }

}