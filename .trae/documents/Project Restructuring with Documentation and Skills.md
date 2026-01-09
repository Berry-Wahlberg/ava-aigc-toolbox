## Project Restructuring Plan

### 1. Project Structure Enhancement
- **Create Documentation Directory**: `docs/wiki/` with subdirectories for developer and user documentation
- **Add Key Documentation Files**: 
  - Developer documentation (technical guides)
  - User documentation (usage guides)

### 2. Skill Files Implementation
Add `skill.md` files to key folders using the established skill format (Workflow-based, Task-based, Reference, Capabilities-based):

#### Core Project Folders
- `src/Application/` - Application layer skills
- `src/Core/` - Domain and interfaces skills  
- `src/Infrastructure/` - Data access skills
- `src/Presentation/` - UI layer skills

#### Application Use Cases
- `src/Application/UseCases/` - Use case patterns
- `src/Application/UseCases/Albums/` - Album-specific operations
- `src/Application/UseCases/Folders/` - Folder-specific operations
- `src/Application/UseCases/Images/` - Image-specific operations
- `src/Application/UseCases/Tags/` - Tag-specific operations

#### Core Components
- `src/Core/Application/Ports/` - Interface definitions
- `src/Core/Domain/` - Domain modeling
- `src/Core/Domain/Entities/` - Entity design

#### Infrastructure
- `src/Infrastructure/Data/` - Database context
- `src/Infrastructure/Repositories/` - Repository implementations

#### Presentation Layer
- `src/Presentation/ViewModels/` - MVVM patterns
- `src/Presentation/Views/` - UI components

### 3. Documentation Content
- **Developer Documentation**: Architecture guides, API references, coding standards
- **User Documentation**: Installation guides, usage tutorials, feature explanations

### 4. Format Requirements
- All files in English
- UTF-8 encoding
- LF line endings
- Skill files follow the established 4-type format (Workflow, Task, Reference, Capabilities)

### 5. Implementation Approach
1. Create documentation directory structure
2. Create base documentation files
3. Add skill.md files to each key folder
4. Ensure consistent formatting across all files