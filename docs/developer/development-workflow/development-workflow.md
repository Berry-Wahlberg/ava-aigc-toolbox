# Development Workflow

This document outlines the development workflow for the AVA AIGC Toolbox project, including the Git workflow, code review process, and build/test procedures.

## Overview

The development workflow is designed to ensure:
- High code quality through review processes
- Clear communication between team members
- Reliable builds and tests
- Smooth integration of new features and bug fixes
- Predictable release cycles

## Development Process

### 1. Issue Tracking

All development work should be associated with an issue in the project's issue tracker. Issues should:
- Be clearly defined with a descriptive title
- Include a detailed description of the problem or feature request
- Be assigned to the appropriate team member
- Have a priority and milestone assigned
- Include any relevant labels (bug, feature, enhancement, etc.)

### 2. Branching Strategy

The project follows a Gitflow-like branching strategy:

#### Main Branches

- **`main`**: Production-ready code
  - Always stable
  - Contains the latest released version
  - Protected from direct commits
  - Updated only through pull requests

#### Supporting Branches

- **`develop`**: Integration branch for feature development
  - Contains the latest development changes
  - Updated through pull requests from feature branches
  - Periodically merged into `main` for releases

- **Feature branches**: For new features and enhancements
  - Created from `develop`
  - Named as `feature/feature-name`
  - Example: `feature/add-album-support`

- **Bugfix branches**: For bug fixes
  - Created from `develop`
  - Named as `bugfix/bug-description`
  - Example: `bugfix/fix-image-tagging`

- **Hotfix branches**: For critical fixes to production code
  - Created from `main`
  - Named as `hotfix/fix-description`
  - Example: `hotfix/critical-security-fix`
  - Merged back into both `main` and `develop`

### 3. Development Workflow Steps

#### Step 1: Create an Issue

Before starting development:
1. Create or assign an issue in the issue tracker
2. Ensure the issue has a clear description and acceptance criteria
3. Assign the issue to yourself
4. Set appropriate labels, priority, and milestone

#### Step 2: Create a Feature/Bugfix Branch

```bash
# Update develop branch first
git checkout develop
git pull origin develop

# Create new branch
# For features: git checkout -b feature/feature-name
# For bug fixes: git checkout -b bugfix/bug-description
git checkout -b feature/add-album-support
```

#### Step 3: Implement the Feature/Bugfix

- Follow the project's [Coding Standards](./coding-standards.md)
- Write unit tests for new functionality
- Ensure all existing tests pass
- Commit changes regularly with descriptive commit messages

#### Step 4: Push Changes and Create Pull Request

```bash
# Push branch to remote
git push origin feature/add-album-support
```

Then:
1. Create a pull request from your branch to `develop`
2. Include a descriptive title and description
3. Reference the associated issue
4. Request review from team members
5. Ensure all CI checks pass

#### Step 5: Code Review

- Reviewers should check for:
  - Code quality and adherence to standards
  - Correctness of implementation
  - Completeness of tests
  - Documentation
  - Potential performance issues
  - Security concerns

- Reviewers should:
  - Leave constructive feedback
  - Approve the PR if it meets all requirements
  - Request changes if needed

#### Step 6: Address Review Comments

- Make the requested changes
- Push the changes to the same branch
- Update the PR description if needed
- Request re-review if necessary

#### Step 7: Merge the Pull Request

Once the PR is approved and all CI checks pass:
1. Merge the PR into `develop`
2. Delete the feature/bugfix branch
3. Close the associated issue

### 4. Release Process

#### Pre-Release Steps

1. Create a release branch from `develop`
   ```bash
   git checkout develop
   git pull origin develop
   git checkout -b release/vX.Y.Z
   ```

2. Update version numbers in:
   - Project files
   - Documentation
   - CHANGELOG.md

3. Run final tests
   ```bash
   dotnet test
   ```

4. Create a pull request from `release/vX.Y.Z` to `main`
5. Get approval from the team
6. Merge the release branch into `main`
7. Create a tag for the release
   ```bash
   git tag vX.Y.Z
   git push origin vX.Y.Z
   ```
8. Merge the release branch back into `develop`

#### Post-Release Steps

1. Create a GitHub Release with:
   - Release notes
   - Changelog
   - Download links for the release artifacts

2. Notify the team and stakeholders

3. Update any external documentation

## Build and Test Process

### 1. Local Development

#### Building the Project

```bash
# Build the entire solution
dotnet build

# Build a specific project
dotnet build src/Presentation/AIGenManager.Presentation.csproj
```

#### Running Tests

```bash
# Run all tests
dotnet test

# Run tests for a specific project
dotnet test src/Application/AIGenManager.Application.csproj

# Run tests with coverage report
dotnet test --collect:"XPlat Code Coverage"
```

#### Running the Application

```bash
# Run the application
dotnet run --project src/Presentation/AIGenManager.Presentation.csproj

# Run in Release mode
dotnet run --project src/Presentation/AIGenManager.Presentation.csproj --configuration Release
```

#### Code Formatting

```bash
# Format code according to standards
dotnet format
```

### 2. Continuous Integration (CI)

The project uses CI to automatically build, test, and validate code changes. The CI pipeline:

1. Runs on every push to any branch
2. Builds the solution
3. Runs all tests
4. Checks code formatting
5. Performs static code analysis
6. Generates coverage reports

#### CI Workflow

```
┌────────────────┐
│ Push to GitHub │
└────────────────┘
        │
        ▼
┌────────────────┐
│   CI Pipeline  │
└────────────────┘
        │
        ▼
┌────────────────┐   ┌────────────────┐   ┌────────────────┐
│   Build Code   │──▶│   Run Tests    │──▶│ Code Analysis  │
└────────────────┘   └────────────────┘   └────────────────┘
        │
        ▼
┌────────────────┐
│   Report      │
│  Results      │
└────────────────┘
```

#### CI Configuration

The CI configuration is defined in `.github/workflows/ci.yml` and includes:
- Build matrix for different OS (Windows, macOS, Linux)
- Test execution with coverage reporting
- Code formatting checks
- Static code analysis

### 3. Continuous Deployment (CD)

For releases, the CD pipeline:
1. Builds the application for all target platforms
2. Creates installers/packages for each platform
3. Publishes the release artifacts
4. Updates documentation

## Code Review Process

### 1. Reviewer Responsibilities

- Review code within 24-48 hours of PR submission
- Provide constructive feedback
- Check for adherence to coding standards
- Verify that all tests pass
- Ensure the code meets the requirements specified in the issue
- Look for potential performance issues and security vulnerabilities
- Approve the PR if it meets all requirements

### 2. Author Responsibilities

- Ensure the PR has a clear title and description
- Reference the associated issue
- Provide context for the changes
- Ensure all tests pass
- Respond to review comments in a timely manner
- Make requested changes and update the PR
- Request re-review if necessary

### 3. Review Checklist

Reviewers should check:

#### Code Quality
- [ ] Follows coding standards
- [ ] Is well-documented
- [ ] Uses appropriate design patterns
- [ ] Has meaningful variable and function names
- [ ] Avoids code duplication

#### Functionality
- [ ] Implements the requested feature or fix
- [ ] Meets the acceptance criteria
- [ ] Handles edge cases
- [ ] Has appropriate error handling

#### Tests
- [ ] Includes unit tests for new functionality
- [ ] All existing tests pass
- [ ] Tests cover critical paths
- [ ] Test names are descriptive

#### Security
- [ ] No sensitive information exposed
- [ ] Input validation is implemented
- [ ] No potential security vulnerabilities

#### Performance
- [ ] Code is efficient
- [ ] No obvious performance bottlenecks
- [ ] Database queries are optimized

## Communication

### 1. Daily Standups
- Brief updates on progress and blockers
- Focus on what was done, what will be done, and any issues
- Keep meetings short (15-20 minutes)

### 2. Weekly Syncs
- Review progress on milestones
- Discuss upcoming work
- Address any project-wide issues
- Plan for the upcoming week

### 3. Documentation
- Keep documentation up-to-date
- Update README.md for any significant changes
- Document new features and changes in the CHANGELOG.md

## Best Practices

1. **Small, Focused PRs**: Keep pull requests small and focused on a single issue
2. **Frequent Commits**: Commit changes regularly with descriptive messages
3. **Test Early, Test Often**: Write tests as you develop, not after
4. **Code Review Etiquette**: Be respectful and constructive in reviews
5. **Update Documentation**: Keep documentation in sync with code changes
6. **Follow the Process**: Adhere to the established workflow and standards
7. **Communicate**: Keep team members informed of progress and issues

## Tools and Resources

### Development Tools

- **IDE**: Visual Studio 2022 or Visual Studio Code
- **Version Control**: Git
- **Issue Tracking**: GitHub Issues
- **CI/CD**: GitHub Actions
- **Build System**: .NET CLI

### Useful Commands Summary

| Command | Description |
|---------|-------------|
| `git checkout -b branch-name` | Create and switch to a new branch |
| `dotnet build` | Build the solution |
| `dotnet test` | Run all tests |
| `dotnet run --project src/Presentation/AIGenManager.Presentation.csproj` | Run the application |
| `dotnet format` | Format code according to standards |
| `git push origin branch-name` | Push branch to remote |
| `git pull origin branch-name` | Pull latest changes from remote |

## Troubleshooting

### Common Issues

1. **Build Failures**: Check error messages, ensure dependencies are installed, run `dotnet restore`
2. **Test Failures**: Review test results, check for broken functionality
3. **Git Conflicts**: Resolve conflicts manually, use `git mergetool` if needed
4. **CI Failures**: Review CI logs, check for formatting issues, test failures, or build errors

### Getting Help

- Ask for help in the project's communication channels
- Review existing documentation
- Check the issue tracker for similar issues
- Reach out to team members for assistance

## Conclusion

Following this development workflow ensures that the AVA AIGC Toolbox project maintains high code quality, follows best practices, and delivers reliable software. All team members are expected to adhere to these guidelines to ensure smooth and efficient development processes.

---

*Last updated: January 2026*