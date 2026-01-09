# Presentation Layer Skills

## Overview
This document defines the skills for working with the Presentation layer of the AVA AIGC Toolbox. The Presentation layer contains the user interface components, view models, and application entry point built with Avalonia UI and the MVVM pattern.

## 1. Workflow-based Skills

### MVVM Development Workflow
- **Type**: Workflow-based
- **Description**: Complete process for developing MVVM components
- **Steps**:
  1. Identify the UI component to create
  2. Create the ViewModel class inheriting from `ViewModelBase`
  3. Implement properties with `ObservableProperty` attribute
  4. Implement commands with `RelayCommand` attribute
  5. Create the View (XAML file)
  6. Bind View to ViewModel properties and commands
  7. Test the UI component
- **Implementation**: Follow the pattern in `MainWindowViewModel.cs` and `MainWindow.axaml`

### Application Startup Workflow
- **Type**: Workflow-based
- **Description**: Process for configuring and starting the application
- **Steps**:
  1. Configure dependency injection in `App.axaml.cs`
  2. Initialize Avalonia framework
  3. Create main window with ViewModel
  4. Start the application message loop
- **Implementation**: `src/Presentation/App.axaml.cs` and `src/Presentation/Program.cs`

## 2. Task-based Skills

### Presentation Operations
- **Type**: Task-based
- **Description**: Collection of operations for working with the Presentation layer
- **Operations**:
  - CreateViewModel: Create a new ViewModel class
  - AddObservableProperties: Implement bindable properties with `ObservableProperty`
  - AddCommands: Implement commands with `RelayCommand`
  - CreateView: Create a new XAML View
  - BindUIElements: Connect View elements to ViewModel properties/commands
  - ConfigureDI: Register ViewModels in the dependency injection container
  - TestUI: Verify UI functionality

### Presentation Components
- **Type**: Task-based
- **Description**: Key components of the Presentation layer
- **Components**:
  - ViewModels: `src/Presentation/ViewModels/`
  - Views: `src/Presentation/Views/`
  - Application Entry: `src/Presentation/Program.cs` and `src/Presentation/App.axaml.cs`
  - Assets: `src/Presentation/Assets/`

## 3. Reference/Guidelines

### MVVM Best Practices
- **Type**: Reference
- **Description**: Standards for implementing MVVM pattern
- **Guidelines**:
  - Use `ViewModelBase` as the base class for all ViewModels
  - Use `ObservableProperty` attribute for bindable properties
  - Use `RelayCommand` for commands
  - Keep ViewModel logic focused on UI state management
  - Avoid business logic in ViewModels (use use cases instead)
  - Use dependency injection for ViewModel dependencies
- **Example**: `src/Presentation/ViewModels/MainWindowViewModel.cs`

### Avalonia UI Guidelines
- **Type**: Reference
- **Description**: Best practices for Avalonia UI development
- **Guidelines**:
  - Use XAML for UI definition
  - Keep code-behind minimal
  - Use data binding extensively
  - Follow Avalonia's naming conventions
  - Use resources for consistent styling
  - Implement responsive design
- **Example**: `src/Presentation/Views/MainWindow.axaml`

### Naming Conventions
- **Type**: Reference
- **Description**: Naming standards for Presentation layer components
- **Guidelines**:
  - ViewModels: PascalCase with "ViewModel" suffix (e.g., `MainWindowViewModel`)
  - Views: PascalCase with no suffix (e.g., `MainWindow`)
  - Properties: PascalCase (e.g., `SelectedImage`)
  - Commands: PascalCase with "Command" suffix (e.g., `SaveImageCommand`)
  - Private fields: camelCase with underscore prefix (e.g., `_imageService`)

## 4. Capabilities-based Skills

### UI Layer
- **Type**: Capabilities-based
- **Description**: Complete user interface functionality
- **Capabilities**:
  - MVVM pattern implementation
  - Data binding and command handling
  - UI component lifecycle management
  - Responsive design
  - Theme and styling support
  - User interaction handling
- **Implementation**: `src/Presentation/Views/` and `src/Presentation/ViewModels/` directories

### Application Infrastructure
- **Type**: Capabilities-based
- **Description**: Application startup and configuration
- **Capabilities**:
  - Dependency injection configuration
  - Avalonia framework initialization
  - Window management
  - Application lifecycle events
  - Error handling and logging
- **Implementation**: `src/Presentation/App.axaml.cs` and `src/Presentation/Program.cs`

## How to Use These Skills

### For New UI Component Development
1. Follow the **MVVM Development Workflow**
2. Refer to **MVVM Best Practices** and **Avalonia UI Guidelines**
3. Use the CommunityToolkit.Mvvm attributes for properties and commands
4. Test the UI component thoroughly

### For Application Startup Changes
1. Modify `App.axaml.cs` for DI configuration changes
2. Update `Program.cs` for framework initialization changes
3. Test the application startup process

### For Troubleshooting
1. Check data bindings in the View
2. Verify ViewModel properties are properly annotated
3. Ensure commands are correctly implemented
4. Check dependency injection registration
5. Use Avalonia DevTools for runtime debugging

This skills document provides a framework for effectively working with the Presentation layer of the AVA AIGC Toolbox. Follow these guidelines to ensure a maintainable and responsive user interface.