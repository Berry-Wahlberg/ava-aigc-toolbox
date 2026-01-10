# ViewModels Skills

## 1. Core Responsibility
- Implements ViewModels that connect the UI to application logic, managing UI state and delegating business operations to use cases.

## 2. Core Development Rules
1. **Naming Conventions**: 
   - ViewModel class name: PascalCase with "ViewModel" suffix (e.g., `MainWindowViewModel`)
   - Properties: PascalCase (e.g., `SelectedImage`)
   - Commands: PascalCase with "Command" suffix (e.g., `SaveCommand`)
2. **Base Class Requirement**: 
   - All ViewModels must inherit from `ViewModelBase`
   - `ViewModelBase` provides common functionality for all ViewModels
3. **Property Implementation**: 
   - Use `[ObservableProperty]` attribute for automatic INotifyPropertyChanged
   - Private fields for properties use underscore prefix (e.g., `_propertyName`)
4. **Command Implementation**: 
   - `[RelayCommand]` for synchronous commands
   - `[RelayCommand]` with async methods for asynchronous commands
   - Command logic in private methods
   - Use `[RelayCommand(CanExecute = "CanExecuteMethod")]` for conditional commands
5. **Dependency Rules**: 
   - Only depend on use cases (no direct repositories)
   - Constructor injection for all dependencies
   - Register all ViewModels as Transient in `App.axaml.cs`
6. **Business Logic**: 
   - No business logic in ViewModels
   - Delegate all business operations to injected use cases

## 3. Common Patterns
### Observable Property and Command Pattern
```csharp
public partial class ViewModelName : ViewModelBase
{
    // Observable property with automatic INotifyPropertyChanged
    [ObservableProperty]
    private string _propertyName;
    
    // Async command with automatic ICommand implementation
    [RelayCommand]
    private async Task AsyncCommandName()
    {
        try
        {
            // Delegate to use case for business logic
            var result = await _useCase.ExecuteAsync();
            PropertyName = result;
        }
        catch (Exception ex)
        {
            // Handle UI error
            ErrorMessage = ex.Message;
        }
    }
    
    // Conditional command example
    [RelayCommand(CanExecute = nameof(CanExecuteCommand))]
    private void SyncCommandName()
    {
        // Simple synchronous operation
        _useCase.ExecuteSync();
    }
    
    private bool CanExecuteCommand()
    {
        // Command availability logic
        return !string.IsNullOrWhiteSpace(PropertyName);
    }
    
    private readonly IUseCase _useCase;
    
    public ViewModelName(IUseCase useCase)
    {
        _useCase = useCase;
    }
}
```

## 4. Capability List
- Observable property management with automatic INotifyPropertyChanged
- Command handling (synchronous and asynchronous)
- UI state management
- Use case delegation for business logic
- Error handling for UI presentation

## 5. Skill Loading Rules
- No subdirectories in ViewModels, all skills loaded from this file
- Available ViewModels: `MainWindowViewModel` (main application window), `ViewModelBase` (base class for all ViewModels)