using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace BerryAIGC.Toolkit.Behaviors;

public static class FocusBehavior
{
    public static readonly AttachedProperty<bool> SelectOnFocusProperty =
        AvaloniaProperty.RegisterAttached<SelectOnFocusBehavior, AvaloniaObject, bool>(
            "SelectOnFocus",
            false,
            false);

    public static bool GetSelectOnFocus(AvaloniaObject element)
    {
        return element.GetValue(SelectOnFocusProperty);
    }

    public static void SetSelectOnFocus(AvaloniaObject element, bool value)
    {
        element.SetValue(SelectOnFocusProperty, value);
    }

    static FocusBehavior()
    {
        SelectOnFocusProperty.Changed.Subscribe(OnSelectOnFocusChanged);
    }

    private static void OnSelectOnFocusChanged(AvaloniaObject element, bool newValue)
    {
        if (element is Control control)
        {
            if (newValue)
            {
                control.GotFocus += (s, e) =>
                {
                    if (control is TextBox textBox)
                    {
                        textBox.SelectAll();
                    }
                };
            }
            else
            {
                control.GotFocus -= (s, e) =>
                {
                    if (control is TextBox textBox)
                    {
                        textBox.SelectAll();
                    }
                };
            }
        }
    }
}
