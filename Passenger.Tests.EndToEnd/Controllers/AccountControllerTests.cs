using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Newtonsoft.Json;
using Passenger.Api;
using Passenger.Infrastructure.Commands.User;
using Xunit;

namespace Passenger.Tests.EndToEnd.Controllers
{
    public class AccountControllerTests : ControllerTestBase
    {
        [Fact]
        public async Task given_valid_current_and_newpassword_it_should_be_changed()
        {
            var command = new ChangeUserPassword
            {
                CurrentPassword = "Secret",
                NewPassword = "Secret2"
            };

            var json = JsonConvert.SerializeObject(command);
            var stringContent = new StringContent(json, Encoding.UTF8, "application/json");
            var request = await Client.PutAsync("account/password", stringContent);
            request.StatusCode.ShouldBeEquivalentTo(HttpStatusCode.NoContent);
        }
    }
}