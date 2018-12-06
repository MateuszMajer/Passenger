using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace Passenger.Tests.Services
{
    public class ExampleTest
    {
        [Fact]
        public async Task Test()
        {
            true.ShouldBeEquivalentTo(true);

        }
    }
}