# Views Skills

## 1. Core Responsibility
- Implements Avalonia XAML views that define the user interface, with extensive data binding to ViewModels for interactive functionality.

## 2. Core Development Rules
1. **Naming Conventions**: 
   - View file name: PascalCase.axaml (e.g., `MainWindow.axaml`)
   - Code-behind file: Same name with .cs extension (e.g., `MainWindow.axaml.cs`)
   - Control names: Meaningful PascalCase if needed for code-behind (e.g., `SaveButton`)
2. **XAML Usage**: 
   - XAML for all UI definition, minimal code-behind
   - Extensive data binding between View and ViewModel
   - Responsive design with adaptive layouts
   - Use resources for consistent styling
3. **Data Binding Rules**: 
   - `{Binding PropertyName}` for simple property binding
   - `{Binding CommandName}` for command binding
   - `Mode=TwoWay` for editable controls (TextBox, CheckBox, etc.)
   - `Mode=OneWay` for read-only displays (TextBlock, Image, etc.)
   - `Mode=OneTime` for static data
4. **Layout Standards**: 
   - Use Grid for complex layouts with rows/columns
   - Use StackPanel for linear arrangements
   - Use appropriate spacing and margins
   - Test layouts with different window sizes
5. **Code-Behind Rules**: 
   - Minimal code-behind (only for UI-specific logic)
   - No business logic in code-behind
   - Hook up event handlers only if data binding isn't feasible

## 3. Common Patterns
### Data Binding and Command Pattern
```xml
<!-- Simple XAML View with data binding -->
<Window x:Class="Namespace.ViewName"
        xmlns="https://github.com/avaloniaui"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        Title="View Title">
    <Grid>
        <!-- Property binding -->
        <TextBlock Text="{Binding PropertyName}" />
        
        <!-- Two-way binding for editable control -->
        <TextBox Text="{Binding EditableProperty, Mode=TwoWay}" />
        
        <!-- Command binding -->
        <Button Content="Action" Command="{Binding ActionCommand}" />
        
        <!-- Command binding with parameter -->
        <Button Content="Delete" Command="{Binding DeleteCommand}" CommandParameter="{Binding SelectedItem}" />
        
        <!-- Conditional command binding -->
        <Button Content="Save" Command="{Binding SaveCommand}" IsEnabled="{Binding CanSave}" />
    </Grid>
</Window>
```

## 4. Capability List
- XAML layout and UI design
- Data binding between View and ViewModel
- Command handling for user interactions
- Responsive design with adaptive layouts
- Avalonia control usage and styling
- Resource management for consistent theming

## 5. Skill Loading Rules
- No subdirectories in Views, all skills loaded from this file
- Available Views: `MainWindow.axaml` (main application window), `App.axaml` (application resources and styles)