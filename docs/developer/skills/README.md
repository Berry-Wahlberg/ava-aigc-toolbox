# AVA AIGC Toolbox Skills Documentation

This directory contains skills documentation for each layer of the AVA AIGC Toolbox application. These documents outline the core responsibilities, development rules, common patterns, and implementation guidelines for each layer of the architecture.

## Table of Contents

### Core Layer
- [Core Layer Skills](./core.md) - Core domain models and business logic
  - [Domain Entities](./core-domain-entities.md) - Entity-specific guidelines

### Application Layer
- [Application Layer Skills](./application.md) - Application use cases and orchestration
  - [Album Use Cases](./application-albums.md) - Album-related business logic
  - [Folder Use Cases](./application-folders.md) - Folder-related business logic
  - [Image Use Cases](./application-images.md) - Image-related business logic
  - [Tag Use Cases](./application-tags.md) - Tag-related business logic

### Infrastructure Layer
- [Infrastructure Layer Skills](./infrastructure.md) - Data access and external integrations
  - [Data Access](./infrastructure-data.md) - Database and data storage
  - [Repositories](./infrastructure-repositories.md) - Repository implementations

### Presentation Layer
- [Presentation Layer Skills](./presentation.md) - UI and user interaction
  - [ViewModels](./presentation-viewmodels.md) - MVVM view models
  - [Views](./presentation-views.md) - UI views and controls

## Purpose

These skill documents serve as:
1. **Guidelines**: For developers to follow consistent patterns across the codebase
2. **Reference**: For understanding the responsibilities of each layer
3. **Onboarding**: For new team members to quickly grasp the architecture
4. **Quality Assurance**: To ensure code follows best practices
5. **Documentation**: To preserve architectural decisions and patterns

## Usage

- Refer to these documents when implementing new features
- Use them as a checklist during code reviews
- Update them when architectural patterns evolve
- Share them with new team members during onboarding

## Structure

Each skill document follows this structure:
1. **Core Responsibility**: Brief description of the layer's purpose
2. **Core Development Rules**: Naming conventions, design principles, and constraints
3. **Common Patterns**: Implementation patterns and code examples
4. **Best Practices**: Recommended approaches for common scenarios
5. **Anti-Patterns**: Practices to avoid

## Contribution

To contribute to these documents:
1. Follow the existing structure and formatting
2. Provide clear, concise examples
3. Focus on practical guidelines rather than theoretical concepts
4. Keep content up-to-date with the current codebase
5. Review changes with the team before merging

---

*Last updated: January 2026*