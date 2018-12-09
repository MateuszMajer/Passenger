using System.Net.Http;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Passenger.Api;
using Xunit;

namespace Passenger.Tests.EndToEnd.Controllers
{
    public class UserControllerTests
    {
        protected readonly TestServer Server;
        protected readonly HttpClient Client;

        public UserControllerTests()
        {
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }
        [Fact]
        public async Task given_valid_user_email_should_be_exsist()
        {
            var email="user1@gmail.com";
            var response=await Client.GetAsync($"user/{email}");
            response.Should().NotBeNull();
        }
    }
}