using System.Net.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Passenger.Api;

namespace Passenger.Tests.EndToEnd.Controllers
{
    public class ControllerTestBase
    {
        protected readonly TestServer Server;
        protected readonly HttpClient Client;

        public ControllerTestBase()
        {
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }
    }
}