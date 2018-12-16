using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Newtonsoft.Json;
using Passenger.Api;
using Passenger.Infrastructure.Commands.User;
using Passenger.Infrastructure.DTO;
using Xunit;

namespace Passenger.Tests.EndToEnd.Controllers
{
    public class UserControllerTests : ControllerTestBase
    {
        [Fact]
        private async Task given_valid_user_email_should_exsist()
        {
            var email = "user1@gmail.com";
            var response = await Client.GetAsync($"user/{email}");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            var user = JsonConvert.DeserializeObject<CreateUser>(content);
            user.Email.Should().Be(email);
        }

        [Fact]
        private async Task given_invalid_user_email_should_not_exsist()
        {
            var email = "usedr1@gmail.com";
            var response = await Client.GetAsync($"user/{email}");
            response.StatusCode.ShouldBeEquivalentTo(HttpStatusCode.NotFound);
        }

        [Fact]
        private async Task given_uniqe_user_email_should_be_created()
        {
            var user = new CreateUser
            {
                Email = "mateuszmajer1992@gmail.com",
                UserName = "MateuszMajer",
                Password = "Secret"
            };

            var json = JsonConvert.SerializeObject(user);
            var stringContent = new StringContent(json, Encoding.UTF8, "application/json");
            var request = await Client.PostAsync("user", stringContent);
            request.StatusCode.ShouldBeEquivalentTo(HttpStatusCode.Created);
        }
    }
}