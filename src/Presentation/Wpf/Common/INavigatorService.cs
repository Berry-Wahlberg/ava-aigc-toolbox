
using System.Windows.Controls;
using BerryAIGC.Common;

namespace BerryAIGC.Toolkit.Common;

public interface INavigatorService
{
    void Goto(string url);
    void Back();
    void RegisterRoute(string path, Page page);

}







