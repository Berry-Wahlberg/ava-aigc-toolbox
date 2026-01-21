# 花花AIGC工具箱 (Berry AIGC Toolbox)

一个基于 Avalonia 和 .NET 构建的跨平台 AIGC（AI 生成内容）图像资产管理工具。支持 AI 驱动的图像组织、标签管理、批量处理、格式转换以及 AIGC 工作流助手。可在 Windows、macOS 和 Linux 上无缝运行。

## 功能特性

### 核心功能
- **跨平台支持**：可在 Windows、macOS 和 Linux 上运行
- **AI 驱动的图像管理**：轻松组织和管理 AI 生成的图像
- **高级标签系统**：创建、应用和管理图像标签
- **相册组织**：将图像分组到自定义相册中以便更好地组织
- **文件夹导航**：按原始文件夹结构浏览图像
- **元数据提取**：自动提取 AI 生成的元数据（提示词、反向提示词、步数、采样器等）
- **批量处理**：同时对多张图像执行操作
- **格式转换**：在不同图像格式之间转换
- **AIGC 工作流助手**：简化 AI 内容创建工作流

### AI 功能
- **自动标签**：AI 驱动的图像自动标签
- **元数据识别**：智能提取 AI 生成参数
- **提示词分析**：理解和分类图像提示词
- **工作流集成**：与 AI 生成工具无缝集成

### 用户体验
- **直观界面**：简洁易用的设计
- **键盘快捷键**：高效的键盘导航
- **拖放支持**：轻松导入和组织图像
- **多种视图模式**：网格和列表视图，满足不同偏好
- **高级搜索和筛选**：使用强大的搜索功能快速查找图像

## 安装说明

### 系统要求

#### 最低要求
- **操作系统**：Windows 10+、macOS 10.15+ 或 Linux（Ubuntu 20.04+、Fedora 32+）
- **.NET 运行时**：.NET 7.0 或更高版本
- **磁盘空间**：100 MB 可用空间
- **内存**：最低 2 GB

#### 推荐要求
- **内存**：4 GB 或更多
- **处理器**：多核 CPU
- **显示器**：1080p 或更高分辨率

### 安装方法

#### 1. 使用安装程序（Windows）

1. **下载安装程序**
   - 访问官方网站或 GitHub 发布页面
   - 下载适用于 Windows 的最新 `.exe` 安装程序

2. **运行安装程序**
   - 双击下载的 `.exe` 文件
   - 按照屏幕上的说明操作
   - 选择安装目录（推荐默认值）
   - 选择是否创建桌面和开始菜单快捷方式

3. **启动应用程序**
   - 点击“完成”立即启动应用程序
   - 或稍后使用桌面/开始菜单快捷方式

#### 2. 使用包管理器（macOS/Linux）

##### macOS (Homebrew)
```bash
brew tap berry-aigc-toolbox/tap
brew install berry-aigc-toolbox
```

##### Linux (Snap)
```bash
sudo snap install berry-aigc-toolbox
```

##### Linux (Debian/Ubuntu)
```bash
sudo dpkg -i berry-aigc-toolbox_*.deb
sudo apt-get install -f
```

#### 3. 便携版本（所有平台）

1. **下载便携归档文件**
   - 下载最新的 `.zip`（Windows）或 `.tar.gz`（macOS/Linux）归档文件

2. **提取归档文件**
   - 将内容提取到您选择的目录
   - 无需安装

3. **运行应用程序**
   - Windows：双击 `AIGenManager.exe`
   - macOS/Linux：在终端中运行 `./AIGenManager`

### .NET 运行时安装

如果您尚未安装 .NET 7.0 运行时，需要先安装：

#### Windows
- 从 [https://dotnet.microsoft.com/download/dotnet/7.0](https://dotnet.microsoft.com/download/dotnet/7.0) 下载
- 运行安装程序并按照说明操作

#### macOS
```bash
brew install --cask dotnet-sdk
```

#### Linux
```bash
# Ubuntu/Debian
sudo apt-get update
sudo apt-get install -y dotnet-runtime-7.0

# Fedora
sudo dnf install -y dotnet-runtime-7.0
```

## 使用说明

### 首次启动

当您首次启动应用程序时：

1. **欢迎屏幕**
   - 您将看到一个欢迎屏幕，提供以下选项：
     - 从空库开始
     - 导入现有图像
     - 了解有关应用程序的更多信息

2. **选择您的选项**
   - **从空库开始**：为您的图像创建新数据库
   - **导入现有图像**：让您选择要从中导入图像的文件夹
   - **了解更多**：打开文档

3. **数据库位置**
   - 应用程序会自动创建一个数据库文件：
     - Windows：`%APPDATA%/AIGenManager/aigenmanager.db`
     - macOS：`~/.local/share/AIGenManager/aigenmanager.db`
     - Linux：`~/.local/share/AIGenManager/aigenmanager.db`

### 基本导航

主窗口分为几个部分：

- **侧边栏**：浏览文件夹、相册、标签和所有图像
- **主要内容区域**：以网格或列表视图显示图像
- **图像详情**：显示选中图像的元数据和属性
- **工具栏**：访问导入、排序、筛选和视图选项
- **状态栏**：显示图像总数、当前筛选条件和应用程序状态

### 添加图像

#### 从文件系统
1. 点击工具栏中的 **导入** 按钮
2. 选择 **从文件夹导入**
3. 选择包含图像的文件夹
4. 点击 **选择文件夹** 开始导入

#### 拖放
1. 打开文件资源管理器/查找器
2. 选择一张或多张图像
3. 将它们拖放到应用程序的主要内容区域
4. 图像将被添加到您的库中

### 组织图像

#### 创建相册
1. 点击侧边栏中 "相册" 旁边的 **+** 按钮
2. 输入相册名称
3. 按 Enter 键创建
4. 将图像从网格拖放到相册中添加它们

#### 添加标签

##### 到单张图像
1. 在网格中选择一张图像
2. 在详情面板中，找到 "标签" 部分
3. 点击 **+** 按钮
4. 输入标签名称并按 Enter 键

##### 到多张图像
1. 使用 Ctrl/Cmd + 点击选择多张图像
2. 右键单击并选择 **添加标签**
3. 输入用逗号分隔的标签名称
4. 点击 **添加** 将标签应用到所有选中的图像

### 搜索和筛选

#### 基本搜索
1. 在窗口顶部的搜索框中输入
2. 结果将在您输入时自动显示
3. 搜索匹配文件名、标签和元数据

#### 高级筛选
1. 点击工具栏中的 **筛选** 按钮
2. 设置筛选条件：
   - 文件夹
   - 相册
   - 标签
   - 评分
   - 日期范围
   - 尺寸
   - AI 元数据（模型、采样器等）
3. 点击 **应用** 查看筛选结果

### 键盘快捷键

- **Ctrl/Cmd + K**：显示所有键盘快捷键
- **Ctrl/Cmd + I**：导入图像
- **Ctrl/Cmd + F**：聚焦搜索框
- **Ctrl/Cmd + A**：选择所有图像
- **Delete**：删除选中的图像
- **Space**：预览选中的图像
- **Ctrl/Cmd + 1**：网格视图
- **Ctrl/Cmd + 2**：列表视图

## 配置选项

### 数据库配置

应用程序使用 SQLite 进行数据存储。数据库文件会自动创建在：
- Windows：`%APPDATA%/AIGenManager/aigenmanager.db`
- macOS：`~/.local/share/AIGenManager/aigenmanager.db`
- Linux：`~/.local/share/AIGenManager/aigenmanager.db`

要备份您的数据，只需将此文件复制到安全位置即可。

### 应用程序设置

应用程序设置存储在：
- Windows：`%APPDATA%/AIGenManager/settings.json`
- macOS：`~/.local/share/AIGenManager/settings.json`
- Linux：`~/.local/share/AIGenManager/settings.json`

设置包括：
- UI 首选项（视图模式、主题等）
- 导入设置
- 搜索和筛选首选项
- 键盘快捷键自定义

### 自定义选项

应用程序支持各种自定义选项：
- **主题**：浅色和深色主题
- **视图选项**：网格大小、列表列等
- **排序首选项**：默认排序顺序
- **元数据显示**：选择要显示的元数据字段

## 贡献指南

### 架构概述

项目遵循清洁架构原则，包含以下层：

1. **表示层**：使用 Avalonia 构建的 UI 组件和视图模型
2. **应用层**：实现业务逻辑的用例
3. **核心层**：领域模型、实体和接口
4. **基础设施层**：数据访问和外部集成

### 编码标准

- 遵循 C# 编码约定
- 对所有依赖项使用依赖注入
- 在核心层实现接口，在基础设施层实现具体类
- 对所有应用程序逻辑使用用例模式
- 遵循 SOLID 原则

### 开发设置

1. **先决条件**
   - .NET 7.0 SDK 或更高版本
   - Visual Studio、Rider 或带有 C# 扩展的 VS Code
   - Git

2. **克隆仓库**
   ```bash
   git clone https://github.com/berry-aigc-toolbox/berry-aigc-toolbox.git
   cd berry-aigc-toolbox
   ```

3. **构建项目**
   ```bash
   dotnet build
   ```

4. **运行应用程序**
   ```bash
   dotnet run --project src/Presentation/AIGenManager.Presentation.csproj
   ```

### 贡献工作流程

1. Fork 仓库
2. 创建功能分支
3. 实现您的更改
4. 运行测试（如果可用）
5. 使用描述性提交消息提交您的更改
6. 推送到您的 fork
7. 创建拉取请求

## 许可证

本项目采用 MIT 许可证。有关详细信息，请参阅 [LICENSE](LICENSE) 文件。

## 致谢

- **Avalonia UI**：跨平台 UI 框架
- **.NET**：强大的开发平台
- **SQLite**：轻量级数据库引擎
- **SQLite-net**：.NET 的 SQLite ORM

## 联系方式

- **GitHub 仓库**：[https://github.com/berry-aigc-toolbox/berry-aigc-toolbox](https://github.com/berry-aigc-toolbox/berry-aigc-toolbox)
- **问题页面**：[https://github.com/berry-aigc-toolbox/berry-aigc-toolbox/issues](https://github.com/berry-aigc-toolbox/berry-aigc-toolbox/issues)
- **文档**：[https://github.com/berry-aigc-toolbox/berry-aigc-toolbox/docs](https://github.com/berry-aigc-toolbox/berry-aigc-toolbox/docs)

## 支持

如需支持，请：
1. 查看 [文档](https://github.com/berry-aigc-toolbox/berry-aigc-toolbox/docs)
2. 搜索现有的 [问题](https://github.com/berry-aigc-toolbox/berry-aigc-toolbox/issues)
3. 如果找不到解决方案，请创建新问题

## 更新日志

有关最新更改，请参阅 [CHANGELOG](CHANGELOG.md) 文件。
