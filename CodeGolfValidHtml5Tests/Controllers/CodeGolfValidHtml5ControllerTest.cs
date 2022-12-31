using System.Net;
using Microsoft.AspNetCore.Mvc.Testing;

namespace CodeGolfValidHtml5Tests.Controllers;

public class CodeGolfValidHtml5ControllerTest : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly HttpClient _client;

    public CodeGolfValidHtml5ControllerTest(WebApplicationFactory<Program> factory)
    {
        _client = factory.CreateClient();
    }

    [Fact]
    public async Task TestGetCodeGolfValidHtml5()
    {
        // Arrange
        var expected = "<!DOCTYPE html><html lang=\"\"><meta charset=\"UTF-8\"><title>.</title>";

        // Act
        var response = await _client.GetAsync("/");
        var actual = await response.Content.ReadAsStringAsync();

        // Assert
        response.EnsureSuccessStatusCode();
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        Assert.Equal(expected, actual);
    }
}
