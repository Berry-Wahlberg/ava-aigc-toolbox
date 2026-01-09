# ViewModels Skills

## Overview
This document defines the skills for working with ViewModels in the AVA AIGC Toolbox. The ViewModels directory contains the MVVM ViewModels that connect the UI with the application logic using CommunityToolkit.Mvvm attributes.

## 1. Workflow-based Skills

### ViewModel Development Workflow
- **Type**: Workflow-based
- **Description**: Complete process for developing MVVM ViewModels
- **Steps**:
  1. Create ViewModel class inheriting from `ViewModelBase`
  2. Add dependencies via constructor injection
  3. Implement observable properties with `ObservableProperty` attribute
  4. Implement commands with `RelayCommand` attribute
  5. Add async commands with `AsyncRelayCommand` if needed
  6. Connect to use cases for business logic
  7. Test ViewModel functionality
- **Implementation**: Follow the pattern in `MainWindowViewModel.cs`

### Data Binding Workflow
- **Type**: Workflow-based
- **Description**: Process for setting up data binding between View and ViewModel
- **Steps**:
  1. Create ViewModel with observable properties
  2. Create XAML View with binding expressions
  3. Set DataContext of View to ViewModel instance
  4. Test binding updates
  5. Add command bindings for user interactions
- **Implementation**: See `MainWindowViewModel.cs` and `MainWindow.axaml`

## 2. Task-based Skills

### ViewModel Operations
- **Type**: Task-based
- **Description**: Collection of operations for working with ViewModels
- **Operations**:
  - CreateViewModelClass: Define a new ViewModel inheriting from `ViewModelBase`
  - AddDependencies: Inject use cases and services via constructor
  - ImplementObservableProperties: Add bindable properties with `ObservableProperty`
  - ImplementCommands: Create commands with `RelayCommand` or `AsyncRelayCommand`
  - AddBusinessLogic: Connect to use cases for application logic
  - RegisterInDI: Add ViewModel to dependency injection container

### Available ViewModels
- **Type**: Task-based
- **Description**: List of existing ViewModels
- **ViewModels**:
  - `MainWindowViewModel`: Main application window ViewModel
  - `ViewModelBase`: Base class for all ViewModels

## 3. Reference/Guidelines

### ViewModel Implementation Guidelines
- **Type**: Reference
- **Description**: Standards for implementing ViewModels
- **Guidelines**:
  - Inherit from `ViewModelBase` for all ViewModels
  - Use `ObservableProperty` attribute for bindable properties
  - Use `RelayCommand` for synchronous commands
  - Use `AsyncRelayCommand` for asynchronous commands
  - Keep business logic in use cases, not in ViewModels
  - Use constructor injection for dependencies
  - Implement IDisposable if needed for resource cleanup
- **Example**: `MainWindowViewModel.cs`

### CommunityToolkit.Mvvm Usage Guidelines
- **Type**: Reference
- **Description**: Best practices for using CommunityToolkit.Mvvm
- **Guidelines**:
  - Use `[ObservableProperty]` for automatic INotifyPropertyChanged implementation
  - Use `[RelayCommand]` for simple commands
  - Use `[RelayCommand(CanExecute = "CanExecuteMethod")]` for commands with conditions
  - Use `[ObservableProperty(SetterAccess = AccessModifier.Private)]` for read-only properties
  - Implement command logic in private methods
- **Example**: Property and command implementations in `MainWindowViewModel.cs`

### Naming Conventions
- **Type**: Reference
- **Description**: Naming standards for ViewModel components
- **Guidelines**:
  - ViewModel classes: PascalCase with "ViewModel" suffix (e.g., `MainWindowViewModel`)
  - Properties: PascalCase (e.g., `SelectedImage`, `Images`)
  - Commands: PascalCase with "Command" suffix (e.g., `SaveCommand`)
  - Command methods: Private PascalCase methods (e.g., `SaveImage`)
  - Private fields: camelCase with underscore prefix (e.g., `_imageUseCase`)

## 4. Capabilities-based Skills

### MVVM Layer
- **Type**: Capabilities-based
- **Description**: Complete MVVM ViewModel functionality
- **Capabilities**:
  - Observable property implementation
  - Command handling
  - Async command support
  - Dependency injection integration
  - UI state management
  - Event handling
- **Implementation**: `ViewModelBase.cs` and all ViewModel classes

### Application UI Logic
- **Type**: Capabilities-based
- **Description**: UI-specific logic implementation
- **Capabilities**:
  - Data binding setup
  - Command routing
  - Loading states
  - Error handling for UI
  - Navigation logic
  - User interaction handling
- **Implementation**: `MainWindowViewModel.cs` and future ViewModels

## How to Use These Skills

### For Creating New ViewModels
1. Follow the **ViewModel Development Workflow**
2. Apply **ViewModel Implementation Guidelines**
3. Use CommunityToolkit.Mvvm attributes for properties and commands
4. Inject necessary use cases via constructor
5. Register the ViewModel in the DI container

### For Working with Existing ViewModels
1. Understand the ViewModel's properties and commands
2. Use dependency injection to get instances
3. Follow existing naming and implementation patterns
4. Add new properties and commands following the same style
5. Test changes thoroughly

### For Troubleshooting ViewModels
1. Check that properties use `ObservableProperty` attribute
2. Verify commands are properly decorated with `RelayCommand`
3. Ensure dependencies are correctly injected
4. Test command execution and property updates
5. Check data binding expressions in the View

This skills document provides a framework for effectively working with ViewModels in the AVA AIGC Toolbox. Follow these guidelines to ensure consistent and maintainable MVVM implementation.