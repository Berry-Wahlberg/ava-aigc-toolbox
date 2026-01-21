# Presentation Layer Skills

## 1. Core Responsibility
- Implements the user interface using Avalonia UI and MVVM pattern, connecting user interactions to application logic through ViewModels and data binding.

## 2. Core Development Rules
1. **Naming Conventions**: 
   - ViewModel class name: PascalCase with "ViewModel" suffix (e.g., `MainWindowViewModel`)
   - View class name: PascalCase (e.g., `MainWindow`)
   - Properties: PascalCase (e.g., `SelectedImage`)
   - Commands: PascalCase with "Command" suffix (e.g., `SaveImageCommand`)
2. **MVVM Implementation**: 
   - All ViewModels inherit from `ViewModelBase`
   - Use `ObservableProperty` attribute for bindable properties
   - Use `RelayCommand` attribute for commands
   - No business logic in ViewModels (delegate to use cases)
3. **Avalonia UI Usage**: 
   - XAML for UI definition, minimal code-behind
   - Extensive data binding between View and ViewModel
   - Responsive design with adaptive layouts
   - Use resources for consistent styling
4. **Dependency Injection**: 
   - Constructor injection for ViewModel dependencies (use cases only)
   - Register all ViewModels as Transient in `App.axaml.cs`
   - No direct repository dependencies in ViewModels
5. **Application Startup**: 
   - Configure DI container in `App.axaml.cs`
   - Initialize Avalonia framework in `Program.cs`
   - Create main window with ViewModel injection

## 3. Common Patterns
### MVVM ViewModel Pattern
```csharp
public partial class ViewModelName : ViewModelBase
{
    // Observable property with automatic INotifyPropertyChanged
    [ObservableProperty]
    private string _propertyName;
    
    // Relay command with automatic ICommand implementation
    [RelayCommand]
    private async Task CommandName()
    {
        // Delegate to use case for business logic
        var result = await _useCase.ExecuteAsync();
        // Update UI state
        PropertyName = result;
    }
    
    private readonly IUseCase _useCase;
    
    // Constructor with dependency injection
    public ViewModelName(IUseCase useCase)
    {
        _useCase = useCase;
    }
}
```

## 4. Capability List
- MVVM pattern implementation for UI components
- Data binding and command handling
- Avalonia UI framework integration
- Application startup and DI configuration
- User interaction handling
- Responsive UI design

## 5. Skill Loading Rules
- Load `Presentation/ViewModels/` skills for ViewModel development
- Load `Presentation/Views/` skills for XAML View development