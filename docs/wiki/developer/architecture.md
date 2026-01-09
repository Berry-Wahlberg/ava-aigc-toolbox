# Architecture Guide

## Overview
The AVA AIGC Toolbox follows a clean architecture pattern, separating concerns into distinct layers. This promotes maintainability, testability, and flexibility.

## Architecture Layers

### 1. Presentation Layer
- **Responsibility**: User interface and interaction
- **Implementation**: Avalonia UI with MVVM pattern
- **Key Components**:
  - Views (`src/Presentation/Views/`)
  - ViewModels (`src/Presentation/ViewModels/`)
  - Application entry point (`src/Presentation/App.axaml.cs`)

### 2. Application Layer
- **Responsibility**: Application logic and use cases
- **Implementation**: Use case pattern
- **Key Components**:
  - Use cases (`src/Application/UseCases/`)
  - Base use case class (`src/Application/UseCases/BaseUseCases.cs`)

### 3. Core Layer
- **Responsibility**: Domain models and interfaces
- **Implementation**: POCOs and interfaces
- **Key Components**:
  - Domain entities (`src/Core/Domain/Entities/`)
  - Value objects (`src/Core/Domain/ValueObjects/`)
  - Repository interfaces (`src/Core/Application/Ports/`)

### 4. Infrastructure Layer
- **Responsibility**: External dependencies and data access
- **Implementation**: Concrete implementations
- **Key Components**:
  - Database context (`src/Infrastructure/Data/DatabaseContext.cs`)
  - Repositories (`src/Infrastructure/Repositories/`)

## Dependency Flow

Dependencies flow from outer layers to inner layers:
- Presentation → Application → Core → Infrastructure
- Inner layers have no dependencies on outer layers
- All dependencies are injected via the dependency injection container

## Key Patterns

### Use Case Pattern
Each use case represents a single business operation:
- Implemented as classes in `src/Application/UseCases/`
- Follow naming convention: `{Operation}UseCase.cs`
- Example: `GetAllImagesUseCase.cs`

### Repository Pattern
Abstracts data access:
- Interfaces defined in `src/Core/Application/Ports/`
- Implementations in `src/Infrastructure/Repositories/`
- Example: `IImageRepository` → `SQLiteImageRepository`

### MVVM Pattern
Separates UI concerns:
- Views: XAML files with UI definitions
- ViewModels: Bindable properties and commands
- Models: Domain entities

## Data Flow

1. User interacts with UI (Presentation layer)
2. ViewModel calls appropriate use case (Application layer)
3. Use case uses repository interfaces to access data (Core layer)
4. Repository implementation performs database operations (Infrastructure layer)
5. Results flow back up to UI

## Project Structure

```
src/
├── Application/          # Use cases and application logic
│   └── UseCases/         # Business operations
├── Core/                # Domain models and interfaces
│   ├── Application/
│   │   └── Ports/       # Repository interfaces
│   └── Domain/
│       ├── Entities/    # Domain entities
│       └── ValueObjects/# Value objects
├── Infrastructure/      # Data access and external integrations
│   ├── Data/            # Database context
│   └── Repositories/    # Repository implementations
└── Presentation/        # UI components and view models
    ├── ViewModels/      # MVVM view models
    └── Views/           # UI views
```