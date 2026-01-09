# Views Skills

## Overview
This document defines the skills for working with Views in the AVA AIGC Toolbox. The Views directory contains the Avalonia XAML views that form the user interface, along with their code-behind files.

## 1. Workflow-based Skills

### View Development Workflow
- **Type**: Workflow-based
- **Description**: Complete process for developing Avalonia Views
- **Steps**:
  1. Create XAML view file with appropriate layout
  2. Add UI elements and controls
  3. Set up data binding expressions
  4. Add command bindings for user interactions
  5. Implement minimal code-behind if necessary
  6. Test the view with its ViewModel
- **Implementation**: Follow the pattern in `MainWindow.axaml` and `MainWindow.axaml.cs`

### Layout Design Workflow
- **Type**: Workflow-based
- **Description**: Process for designing effective UI layouts
- **Steps**:
  1. Determine the main layout structure (Grid, StackPanel, etc.)
  2. Define rows and columns for Grid layouts
  3. Add UI controls with appropriate sizing
  4. Set up responsive design with Adaptive triggers if needed
  5. Test layout with different window sizes
- **Implementation**: See `MainWindow.axaml` for layout example

## 2. Task-based Skills

### View Operations
- **Type**: Task-based
- **Description**: Collection of operations for working with Views
- **Operations**:
  - CreateXAMLView: Define a new XAML view file
  - AddLayout: Implement layout containers (Grid, StackPanel, etc.)
  - AddControls: Insert UI controls (Button, TextBlock, Image, etc.)
  - SetupDataBinding: Connect controls to ViewModel properties
  - AddCommandBindings: Link controls to ViewModel commands
  - ImplementCodeBehind: Add minimal code-behind if required

### Available Views
- **Type**: Task-based
- **Description**: List of existing Views
- **Views**:
  - `MainWindow.axaml`: Main application window
  - `App.axaml`: Application-level resources and styles

## 3. Reference/Guidelines

### View Implementation Guidelines
- **Type**: Reference
- **Description**: Standards for implementing Avalonia Views
- **Guidelines**:
  - Use XAML for UI definition as much as possible
  - Keep code-behind files minimal
  - Use data binding extensively
  - Follow Avalonia best practices for layout
  - Implement responsive design where appropriate
  - Use resources for consistent styling
  - Set DataContext in the View constructor or via DI
- **Example**: `MainWindow.axaml` and `MainWindow.axaml.cs`

### Data Binding Guidelines
- **Type**: Reference
- **Description**: Best practices for data binding in Avalonia
- **Guidelines**:
  - Use `{Binding PropertyName}` for simple bindings
  - Use `{Binding CommandName}` for command bindings
  - Use `TwoWay` binding for editable controls
  - Use `OneWay` binding for read-only displays
  - Use `OneTime` binding for static data
  - Implement INotifyPropertyChanged in ViewModels
- **Example**: Binding expressions in `MainWindow.axaml`

### XAML Coding Standards
- **Type**: Reference
- **Description**: Standards for writing XAML code
- **Guidelines**:
  - Use proper indentation (4 spaces)
  - Name controls meaningfully when needed for code-behind
  - Use XML comments for complex layouts
  - Group related controls together
  - Use resources for reusable styles
  - Keep XAML files organized and readable

## 4. Capabilities-based Skills

### UI Layer
- **Type**: Capabilities-based
- **Description**: Complete UI functionality
- **Capabilities**:
  - XAML layout and design
  - Data binding with ViewModels
  - Command handling for user interactions
  - Responsive design
  - Resource management
  - Theme support
- **Implementation**: All XAML views in this directory

### Avalonia Integration
- **Type**: Capabilities-based
- **Description**: Avalonia-specific UI functionality
- **Capabilities**:
  - Avalonia control usage
  - Style and template system
  - Data validation integration
  - Navigation support (future)
  - Dialog and window management
- **Implementation**: `MainWindow.axaml` and application infrastructure

## How to Use These Skills

### For Creating New Views
1. Follow the **View Development Workflow**
2. Apply **View Implementation Guidelines**
3. Use data binding extensively
4. Keep code-behind minimal
5. Test with the associated ViewModel

### For Working with Existing Views
1. Understand the layout structure
2. Follow existing XAML coding standards
3. Add new controls following the same pattern
4. Use resources for consistent styling
5. Test changes with different window sizes

### For Troubleshooting Views
1. Check data binding expressions
2. Verify DataContext is set correctly
3. Test command bindings
4. Check for layout issues with Snoop (Avalonia debugging tool)
5. Verify control names if using code-behind

This skills document provides a framework for effectively working with Views in the AVA AIGC Toolbox. Follow these guidelines to ensure a maintainable and responsive user interface.