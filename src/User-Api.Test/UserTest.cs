

using System.Net.Http;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace User_Api.Test;

public class UserTest : IClassFixture<TestingWebAppFactory<Program>>
{
    private readonly HttpClient _client;

    public UserTest(TestingWebAppFactory<Program> factory)
    {
        _client = factory.CreateClient();
    }

    [Fact]
    public async Task ShouldReturnAllUsers()
    {
        var response = await _client.GetAsync("/user");
        response.Should().BeSuccessful();
    }
}