using System.Windows;
using BerryAIGC.Common;

namespace BerryAIGC.Toolkit.Services;

public class WindowService
{
    private Window _window;

    public Window CurrentWindow => _window;

    public void SetWindow(Window window)
    {
        _window = window;
    }
}







