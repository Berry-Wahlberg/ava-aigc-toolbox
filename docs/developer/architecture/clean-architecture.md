# Clean Architecture Overview

## Introduction

The AVA AIGC Toolbox is built using Clean Architecture principles, which promote separation of concerns, maintainability, testability, and flexibility. This architectural style ensures that the core business logic remains independent of external dependencies such as databases, UI frameworks, and third-party libraries.

## What is Clean Architecture?

Clean Architecture, also known as Hexagonal Architecture or Ports and Adapters, is an architectural pattern that organizes software into concentric layers, where each layer has specific responsibilities and dependencies flow inward. The main idea is to keep the core business logic isolated from external concerns.

## Architecture Principles

### 1. Dependency Rule

The most fundamental rule of Clean Architecture is the **Dependency Rule**, which states:

> **Source code dependencies can only point inward. Nothing in an inner circle can know anything at all about something in an outer circle. In particular, the name of something declared in an outer circle must not be mentioned by the code in an inner circle.**

This means that inner layers (like Domain and Application) have no dependencies on outer layers (like Infrastructure and Presentation).

### 2. Separation of Concerns

Each layer has a distinct responsibility, ensuring that changes in one layer have minimal impact on other layers.

### 3. Testability

By isolating the core business logic from external dependencies, we can easily test it without needing to mock complex external systems.

### 4. Flexibility

The architecture allows for easy swapping of external dependencies (e.g., changing from SQLite to PostgreSQL) without modifying the core business logic.

### 5. Maintainability

Clear separation of concerns makes the codebase easier to understand, modify, and extend.

## Architecture Layers

The AVA AIGC Toolbox follows a four-layer Clean Architecture approach:

```
┌─────────────────────────────────────────────────────────────────┐
│                       Presentation Layer                        │
├─────────────────────────────────────────────────────────────────┤
│                      Application Layer                          │
├─────────────────────────────────────────────────────────────────┤
│                           Core Layer                            │
├─────────────────────────────────────────────────────────────────┤
│                     Infrastructure Layer                       │
└─────────────────────────────────────────────────────────────────┘
```

### Layer Responsibilities

| Layer | Responsibility | Dependencies |
|-------|----------------|--------------|
| **Presentation** | User interface and interaction | Application Layer |
| **Application** | Application logic and use cases | Core Layer |
| **Core** | Domain models and business rules | None |
| **Infrastructure** | External dependencies and implementations | Core Layer |

## Key Concepts

### Entities

Entities are the core business objects that represent the fundamental concepts of the application. They encapsulate the business rules and invariants of the domain. Examples in the AVA AIGC Toolbox include:

- `Image`
- `Folder`
- `Album`
- `Tag`
- `ImageTag` (join entity)

### Use Cases

Use cases represent the business operations that the application can perform. Each use case is a discrete unit of work that implements a specific business function. Examples include:

- `GetAllImagesUseCase`
- `AddTagToImageUseCase`
- `GetImagesByAlbumIdUseCase`

### Ports

Ports are abstractions that define the interfaces between layers. They allow inner layers to communicate with outer layers without creating direct dependencies.

- **Input Ports**: Define the interfaces that outer layers use to interact with the application logic (e.g., use case interfaces)
- **Output Ports**: Define the interfaces that the application logic uses to interact with external systems (e.g., repository interfaces)

### Adapters

Adapters are concrete implementations of ports that bridge the gap between the application and external systems.

- **Primary Adapters**: Convert external requests into calls to the application logic (e.g., API controllers, view models)
- **Secondary Adapters**: Implement output ports to communicate with external systems (e.g., database repositories, external APIs)

## Benefits of Clean Architecture

### 1. Independent of Frameworks

The core business logic doesn't depend on any specific framework, allowing for easy migration to new frameworks or versions.

### 2. Testable

Business rules can be tested in isolation without needing UI, database, or external services.

### 3. Independent of UI

The UI can be changed without affecting the core business logic. For example, we could add a web interface without modifying the use cases.

### 4. Independent of Database

We can swap the database (e.g., from SQLite to PostgreSQL) without changing the core business logic.

### 5. Independent of External Agencies

External services and APIs can be changed or replaced without affecting the core business logic.

### 6. Improves Code Organization

Clear separation of concerns makes the codebase more maintainable and easier to understand.

### 7. Facilitates Team Collaboration

Different teams can work on different layers simultaneously without stepping on each other's toes.

## Architecture Visualization

```
┌─────────────────────────────────────────────────────────────────┐
│ Presentation Layer                                              │
│ ┌───────────┐  ┌─────────────┐  ┌────────────────┐             │
│ │   Views   │  │ ViewModels  │  │ API Controllers│             │
│ └───────────┘  └─────────────┘  └────────────────┘             │
└─────────────────────────────────────────────────────────────────┘
                               │
                               ▼
┌─────────────────────────────────────────────────────────────────┐
│ Application Layer                                              │
│ ┌─────────────────────────────────────────────────────────┐     │
│ │                       Use Cases                        │     │
│ └─────────────────────────────────────────────────────────┘     │
└─────────────────────────────────────────────────────────────────┘
                               │
                               ▼
┌─────────────────────────────────────────────────────────────────┐
│ Core Layer                                                     │
│ ┌────────────────┐  ┌────────────────┐  ┌────────────────┐     │
│ │    Entities    │  │  Value Objects │  │    Ports       │     │
│ └────────────────┘  └────────────────┘  └────────────────┘     │
└─────────────────────────────────────────────────────────────────┘
                               │
                               ▼
┌─────────────────────────────────────────────────────────────────┐
│ Infrastructure Layer                                           │
│ ┌────────────────┐  ┌────────────────┐  ┌────────────────┐     │
│ │  Repositories  │  │ External APIs  │  │   Frameworks   │     │
│ └────────────────┘  └────────────────┘  └────────────────┘     │
└─────────────────────────────────────────────────────────────────┘
```

## Data Flow

Data flows through the architecture in a controlled manner, following the Dependency Rule:

1. **User Interaction**: A user interacts with the UI (Presentation Layer)
2. **ViewModel Processing**: The ViewModel processes the user input and calls the appropriate use case (Application Layer)
3. **Use Case Execution**: The use case executes the business logic, using repository interfaces to access data (Core Layer)
4. **Data Access**: Repository implementations (Infrastructure Layer) retrieve or modify data from the database
5. **Result Return**: The result flows back up through the layers to the UI, where it's displayed to the user

## Implementation in AVA AIGC Toolbox

### Layer Implementation

| Layer | Project | Main Components |
|-------|---------|----------------|
| **Core** | AIGenManager.Core | Entities, Value Objects, Ports |
| **Application** | AIGenManager.Application | Use Cases |
| **Infrastructure** | AIGenManager.Infrastructure | Repositories, Database Context |
| **Presentation** | AIGenManager.Presentation | Views, ViewModels |

### Project Structure

```
src/
├── Core/                # Domain models and interfaces
│   ├── Domain/          # Entities, value objects, domain services
│   │   ├── Entities/    # Core business entities
│   │   └── ValueObjects/ # Value objects
│   └── Application/     # Use case interfaces and abstractions
│       └── Ports/       # Repository interfaces
├── Application/         # Application logic and use cases
│   └── UseCases/        # Business operations organized by feature
├── Infrastructure/      # External dependencies and implementations
│   ├── Data/            # Database context and migrations
│   └── Repositories/    # Repository implementations
└── Presentation/        # User interface
    ├── Views/           # UI components (XAML)
    └── ViewModels/      # View models for MVVM
```

## Compliance with Clean Architecture Principles

### 1. Dependency Rule Adherence

- Core layer has no dependencies on other layers
- Application layer depends only on Core layer
- Infrastructure layer depends only on Core layer
- Presentation layer depends on Application and Core layers

### 2. Separation of Concerns

Each layer has a clear, distinct responsibility:

- **Core**: Business rules and domain models
- **Application**: Application-specific business logic
- **Infrastructure**: External dependencies
- **Presentation**: User interaction

### 3. Testability

- Use cases can be tested in isolation using mock repositories
- Domain entities can be tested without external dependencies
- Presentation layer can be tested using view model testing

### 4. Flexibility

- Database can be changed by implementing new repository adapters
- UI can be modified without affecting business logic
- New features can be added by extending use cases

## Conclusion

Clean Architecture provides a solid foundation for the AVA AIGC Toolbox, ensuring that the application is maintainable, testable, and flexible. By following these architectural principles, we can easily adapt to changing requirements, integrate new technologies, and scale the application as needed.

In the following sections, we'll dive deeper into each layer, exploring their components, responsibilities, and interactions in more detail.

---

*Last updated: January 2026*
