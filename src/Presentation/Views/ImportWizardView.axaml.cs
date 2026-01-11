using Avalonia.Controls;
using Avalonia.Interactivity;
using AIGenManager.Presentation.ViewModels;

namespace AIGenManager.Presentation.Views;

public partial class ImportWizardView : UserControl
{
    public ImportWizardView()
    {
        InitializeComponent();
        DataContext = new ImportWizardViewModel(
            App.ServiceProvider.GetRequiredService<ScanFolderUseCase>(),
            App.ServiceProvider.GetRequiredService<GetImportStatisticsUseCase>()
        );
    }
}