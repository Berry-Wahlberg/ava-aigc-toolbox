using Avalonia.Controls;
using Avalonia.Interactivity;
using BerryAIGCToolbox.ViewModels;
using AIGenManager.Application.UseCases.Folders;

namespace BerryAIGCToolbox.Views;

public partial class ImportWizardView : UserControl
{
    public ImportWizardView()
    {
        InitializeComponent();
        // ImportWizardViewModel will be set by the parent view or DI container
    }
}