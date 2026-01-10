# Testing Strategy and Guidelines

This document outlines the testing strategy and guidelines for the AVA AIGC Toolbox project. It covers the types of tests, frameworks, and best practices to ensure the application is reliable, maintainable, and free of bugs.

## Overview

A comprehensive testing strategy is essential for:
- Ensuring code quality and reliability
- Catching bugs early in the development cycle
- Providing confidence when making changes
- Facilitating refactoring and maintenance
- Meeting user expectations for a stable application

## Testing Principles

### 1. Test Early, Test Often
- Write tests as you develop, not after
- Run tests frequently during development
- Integrate tests into the CI/CD pipeline

### 2. Test Coverage
- Aim for high test coverage, especially for critical functionality
- Focus on testing business logic, not implementation details
- Use code coverage tools to identify gaps

### 3. Test Isolation
- Tests should be independent of each other
- Tests should not rely on external dependencies or shared state
- Use mocks and stubs for external dependencies

### 4. Test Readability
- Write clear, descriptive test names
- Use Arrange-Act-Assert pattern for test structure
- Keep tests focused on a single assertion

### 5. Maintainable Tests
- Avoid brittle tests that break easily with changes
- Refactor tests as the codebase evolves
- Remove obsolete tests

## Testing Levels

### 1. Unit Testing

**Purpose**: Test individual components in isolation

**Scope**: 
- Domain entities and value objects
- Use cases
- Services
- Utility functions

**Frameworks**: 
- NUnit or xUnit
- Moq for mocking dependencies
- FluentAssertions for assertions

**Example**: Testing a use case

```csharp
[TestFixture]
public class GetAllImagesUseCaseTests
{
    private GetAllImagesUseCase _useCase;
    private Mock<IImageRepository> _mockImageRepository;
    
    [SetUp]
    public void SetUp()
    {
        _mockImageRepository = new Mock<IImageRepository>();
        _useCase = new GetAllImagesUseCase(_mockImageRepository.Object);
    }
    
    [Test]
    public async Task ExecuteAsync_ReturnsImagesFromRepository()
    {
        // Arrange
        var expectedImages = new List<Image>
        {
            new Image("image1.jpg", "image1.jpg"),
            new Image("image2.jpg", "image2.jpg")
        };
        
        _mockImageRepository.Setup(repo => repo.GetAllAsync())
            .ReturnsAsync(expectedImages);
        
        // Act
        var result = await _useCase.ExecuteAsync();
        
        // Assert
        result.Should().BeEquivalentTo(expectedImages);
        _mockImageRepository.Verify(repo => repo.GetAllAsync(), Times.Once);
    }
}
```

### 2. Integration Testing

**Purpose**: Test interactions between components and external systems

**Scope**: 
- Database operations
- Repository implementations
- API endpoints (if applicable)
- External service integrations

**Frameworks**: 
- NUnit or xUnit
- Entity Framework Core In-Memory Database or SQLite In-Memory
- Testcontainers (for testing with real databases)

**Example**: Testing repository with SQLite in-memory database

```csharp
[TestFixture]
public class SQLiteImageRepositoryTests
{
    private SQLiteImageRepository _repository;
    private DatabaseContext _dbContext;
    private string _connectionString;
    
    [SetUp]
    public void SetUp()
    {
        // Use in-memory SQLite database
        _connectionString = "DataSource=:memory:";
        _dbContext = new DatabaseContext(_connectionString);
        _dbContext.Database.OpenConnection();
        _dbContext.Database.EnsureCreated();
        
        _repository = new SQLiteImageRepository(_dbContext);
    }
    
    [TearDown]
    public void TearDown()
    {
        _dbContext.Database.CloseConnection();
        _dbContext.Dispose();
    }
    
    [Test]
    public async Task AddAsync_PersistsImage()
    {
        // Arrange
        var image = new Image("test.jpg", "test.jpg");
        
        // Act
        await _repository.AddAsync(image);
        
        // Assert
        var retrievedImage = await _repository.GetByIdAsync(image.Id);
        retrievedImage.Should().NotBeNull();
        retrievedImage.FileName.Should().Be("test.jpg");
    }
}
```

### 3. UI Testing

**Purpose**: Test the user interface and user interactions

**Scope**: 
- View models
- UI components and controls
- User workflows and scenarios

**Frameworks**: 
- Avalonia UI Test Framework
- Appium (for cross-platform UI testing)
- Selenium (if there's a web interface)

**Example**: Testing a view model

```csharp
[TestFixture]
public class MainWindowViewModelTests
{
    private MainWindowViewModel _viewModel;
    private Mock<GetAllImagesUseCase> _mockGetAllImagesUseCase;
    private Mock<GetAllFoldersUseCase> _mockGetAllFoldersUseCase;
    
    [SetUp]
    public void SetUp()
    {
        _mockGetAllImagesUseCase = new Mock<GetAllImagesUseCase>();
        _mockGetAllFoldersUseCase = new Mock<GetAllFoldersUseCase>();
        
        _viewModel = new MainWindowViewModel(
            _mockGetAllImagesUseCase.Object,
            _mockGetAllFoldersUseCase.Object);
    }
    
    [Test]
    public async Task LoadImagesCommand_LoadsImagesFromUseCase()
    {
        // Arrange
        var expectedImages = new List<Image>
        {
            new Image("image1.jpg", "image1.jpg"),
            new Image("image2.jpg", "image2.jpg")
        };
        
        _mockGetAllImagesUseCase.Setup(uc => uc.ExecuteAsync())
            .ReturnsAsync(expectedImages);
        
        // Act
        await _viewModel.LoadImagesCommand.ExecuteAsync(null);
        
        // Assert
        _viewModel.Images.Should().BeEquivalentTo(expectedImages);
        _mockGetAllImagesUseCase.Verify(uc => uc.ExecuteAsync(), Times.Once);
    }
}
```

### 4. End-to-End (E2E) Testing

**Purpose**: Test the entire application flow from user perspective

**Scope**: 
- Complete user workflows
- Integration with external systems
- Cross-platform functionality
- Performance and reliability under real conditions

**Frameworks**: 
- Avalonia UI Test Framework
- Appium
- Playwright (if there's a web interface)

**Example**: Testing a complete user workflow

```csharp
[TestFixture]
public class AppEndToEndTests
{
    [Test]
    public void TestAppStartupAndMainWindow()
    {
        // This would typically use Avalonia UI Test Framework
        // to launch the app and interact with it
        // Example is conceptual
        
        // Arrange
        // Initialize test app
        
        // Act
        // 1. Launch the application
        // 2. Verify main window appears
        // 3. Click on "Import Images" button
        // 4. Select a folder with images
        // 5. Verify images are imported and displayed
        
        // Assert
        // Verify expected behavior at each step
    }
}
```

## Testing Frameworks and Tools

### 1. Test Frameworks

| Framework | Purpose | Usage |
|-----------|---------|-------|
| **NUnit** | Unit and integration testing | Primary test framework |
| **xUnit** | Unit and integration testing | Alternative to NUnit |
| **Moq** | Mocking dependencies | For isolating components in unit tests |
| **FluentAssertions** | Assertions | For more readable assertions |

### 2. Testing Libraries

| Library | Purpose | Usage |
|---------|---------|-------|
| **Entity Framework Core In-Memory Database** | Database testing | For testing without real database |
| **SQLite In-Memory** | Database testing | Lightweight real database for testing |
| **Testcontainers** | Containerized testing | For testing with real databases and services |
| **Avalonia UI Test Framework** | UI testing | For testing Avalonia UI components |

### 3. Code Coverage

| Tool | Purpose | Usage |
|------|---------|-------|
| **Coverlet** | Code coverage analysis | Generates coverage reports |
| **ReportGenerator** | Coverage report generation | Creates readable HTML reports |

### 4. CI/CD Integration

- **GitHub Actions**: Runs tests on every push and pull request
- **Build Matrix**: Tests on multiple OS platforms (Windows, macOS, Linux)
- **Parallel Execution**: Runs tests in parallel for faster feedback
- **Coverage Enforcement**: Ensures minimum coverage thresholds are met

## Test Organization

### 1. Project Structure

Tests are organized in separate test projects:

```
tests/
├── AIGenManager.Core.Tests/          # Tests for Core layer
├── AIGenManager.Application.Tests/   # Tests for Application layer
├── AIGenManager.Infrastructure.Tests/ # Tests for Infrastructure layer
└── AIGenManager.Presentation.Tests/  # Tests for Presentation layer
```

### 2. Test Naming Convention

```
{ClassName}{MethodName}{Scenario}{ExpectedBehavior}
```

Example:
- `GetAllImagesUseCase_ExecuteAsync_WhenCalled_ReturnsAllImages`
- `SQLiteImageRepository_AddAsync_WhenImageIsValid_PersistsImage`
- `MainWindowViewModel_LoadImagesCommand_WhenCalled_LoadsImages`

### 3. Test Structure

Use the Arrange-Act-Assert (AAA) pattern:

```csharp
[Test]
public void TestMethod()
{
    // Arrange: Set up test data and dependencies
    
    // Act: Execute the method being tested
    
    // Assert: Verify the expected behavior
}
```

## Test Coverage Goals

### Minimum Coverage Targets

| Component Type | Minimum Coverage |
|----------------|------------------|
| Domain Entities | 80%+ |
| Use Cases | 90%+ |
| Repositories | 80%+ |
| Services | 80%+ |
| View Models | 70%+ |

### Coverage Measurement

```bash
# Generate coverage report for a specific project
dotnet test src/Application/AIGenManager.Application.csproj --collect:"XPlat Code Coverage"

# Generate coverage report for all projects
dotnet test --collect:"XPlat Code Coverage"

# Generate HTML report using ReportGenerator
dotnet tool install -g dotnet-reportgenerator-globaltool
reportgenerator -reports:coverage.cobertura.xml -targetdir:coverage-report -reporttypes:Html
```

## Testing Best Practices

### 1. Write Meaningful Tests
- Tests should be easy to understand
- Test names should describe what is being tested and the expected behavior
- Avoid tests that are too complex or test multiple things at once

### 2. Test Behavior, Not Implementation
- Focus on what the code does, not how it does it
- Avoid testing private methods directly
- Tests should not break when refactoring internal implementation

### 3. Use Test Doubles Wisely
- **Mocks**: For verifying interactions
- **Stubs**: For providing canned responses
- **Fakes**: For lightweight implementations of interfaces
- **Spies**: For recording calls

### 4. Handle Test Data Properly
- Use consistent test data across tests
- Avoid hardcoding test data in tests
- Use test data builders or factories for complex objects

### 5. Keep Tests Fast
- Slow tests can hinder development
- Avoid network calls in unit tests
- Use in-memory databases for testing
- Run tests in parallel when possible

### 6. Test Edge Cases
- Null values
- Empty collections
- Boundary values
- Invalid inputs
- Exception scenarios

### 7. Maintain Tests
- Update tests when requirements change
- Remove obsolete tests
- Refactor tests as the codebase evolves
- Keep test code as clean as production code

## Test Execution

### 1. Running Tests Locally

```bash
# Run all tests
dotnet test

# Run tests for a specific project
dotnet test tests/AIGenManager.Application.Tests/AIGenManager.Application.Tests.csproj

# Run tests with coverage
dotnet test --collect:"XPlat Code Coverage"

# Run tests in parallel
dotnet test --parallel
```

### 2. Running Tests in CI/CD

The CI pipeline automatically runs tests on:
- Every push to any branch
- Every pull request
- Scheduled nightly builds

### 3. Test Reports

Test results and coverage reports are available in:
- CI/CD pipeline logs
- HTML coverage reports (published as artifacts)
- Code coverage badges in the README

## Troubleshooting Tests

### 1. Flaky Tests
- Identify and fix flaky tests immediately
- Ensure tests are properly isolated
- Avoid race conditions and timing issues
- Use deterministic test data

### 2. Test Failures
- Read the test failure message carefully
- Check the stack trace for the exact error location
- Reproduce the failure locally
- Fix the issue and verify with the failing test

### 3. Low Coverage
- Identify areas with low coverage using coverage reports
- Add tests for missing functionality
- Focus on critical paths and business logic
- Avoid writing tests for trivial code

## Conclusion

A comprehensive testing strategy is essential for delivering a high-quality, reliable application. By following these guidelines, the AVA AIGC Toolbox project can ensure that its codebase is thoroughly tested, maintainable, and ready for users.

All team members are expected to adhere to these testing principles and practices to maintain the quality and reliability of the application.

---

*Last updated: January 2026*