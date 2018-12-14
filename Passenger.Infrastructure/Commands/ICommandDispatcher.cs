using System.Threading.Tasks;

namespace Passenger.Infrastructure.Commands
{
    public interface ICommandDispatcher
    {
         Task DisptachAsync<T>() where T: ICommand;
    }
}