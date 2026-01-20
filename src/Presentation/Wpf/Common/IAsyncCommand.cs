using System.Threading.Tasks;
using BerryAIGC.Common;
using System.Windows.Input;

namespace BerryAIGC.Toolkit.Common;

public interface IAsyncCommand<in T> : ICommand
{
    Task ExecuteAsync(T? parameter);
    bool CanExecute(T? parameter);
}







