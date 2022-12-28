using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Newtonsoft.Json;
using User_Api.Web.Models;
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

    [Fact]
    public async Task ShouldReturnUserData()
    {
        User user = new() {UserId=1, FullName="string1", Password="123456", Email="string1@trybe.com"};
        string json =JsonConvert.SerializeObject(user);
        StringContent httpContent = new(json, Encoding.UTF8, "application/json");

        var response = await _client.PostAsync("/user", httpContent).Result.Content.ReadAsStringAsync();
        var result = JsonConvert.DeserializeObject<User>(response);
        result.Should().BeEquivalentTo(user);
    }
}