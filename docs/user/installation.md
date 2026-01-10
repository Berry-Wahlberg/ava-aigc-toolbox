# 安装指南

> **备注：以英文版本为准**

## 概述
本指南将引导您完成在系统上安装 AVA AIGC 工具箱的过程。该应用程序支持 Windows、macOS 和 Linux。

## 系统要求

### 最低要求
- **操作系统**：Windows 10+，macOS 10.15+ 或 Linux（Ubuntu 20.04+，Fedora 32+）
- **.NET 运行时**：.NET 7.0 或更高版本
- **磁盘空间**：100 MB 可用空间
- **内存**：最低 2 GB

### 推荐要求
- **内存**：4 GB 或更多
- **处理器**：多核 CPU
- **显示器**：1080p 或更高分辨率

## 安装方法

### 1. 使用安装程序（Windows）

1. **下载安装程序**
   - 访问官方网站或 GitHub 发布页面
   - 下载适用于 Windows 的最新 `.exe` 安装程序

2. **运行安装程序**
   - 双击下载的 `.exe` 文件
   - 按照屏幕上的说明操作
   - 选择安装目录（推荐使用默认目录）
   - 选择是否创建桌面和开始菜单快捷方式

3. **启动应用程序**
   - 点击 "完成" 立即启动应用程序
   - 或稍后使用桌面/开始菜单快捷方式

### 2. 使用包管理器（macOS/Linux）

#### macOS（Homebrew）
```bash
brew tap ava-aigc-toolbox/tap
brew install ava-aigc-toolbox
```

#### Linux（Snap）
```bash
sudo snap install ava-aigc-toolbox
```

#### Linux（Debian/Ubuntu）
```bash
sudo dpkg -i ava-aigc-toolbox_*.deb
sudo apt-get install -f
```

### 3. 便携式版本（所有平台）

1. **下载便携式归档文件**
   - 下载最新的 `.zip`（Windows）或 `.tar.gz`（macOS/Linux）归档文件

2. **提取归档文件**
   - 将内容提取到您选择的目录
   - 无需安装

3. **运行应用程序**
   - Windows：双击 `AIGenManager.exe`
   - macOS/Linux：从终端运行 `./AIGenManager`

## .NET 运行时安装

如果您没有安装 .NET 7.0 运行时，需要先安装它：

### Windows
- 从 https://dotnet.microsoft.com/download/dotnet/7.0 下载
- 运行安装程序并按照说明操作

### macOS
```bash
brew install --cask dotnet-sdk
```

### Linux
```bash
# Ubuntu/Debian
sudo apt-get update
sudo apt-get install -y dotnet-runtime-7.0

# Fedora
sudo dnf install -y dotnet-runtime-7.0
```

## 验证安装

1. **启动应用程序**
2. **检查版本**
   - 转到 `帮助` > `关于`
   - 验证版本与您下载的版本匹配

3. **测试基本功能**
   - 应用程序应无错误启动
   - 主窗口应正确显示
   - 您应该能够浏览界面

## 故障排除

### 应用程序无法启动
- **检查 .NET 运行时**：确保您安装了正确的 .NET 运行时
- **检查系统要求**：验证您的系统满足最低要求
- **以管理员身份运行**：尝试以管理员权限运行应用程序
- **检查日志**：在 `%APPDATA%/AIGenManager/`（Windows）或 `~/.local/share/AIGenManager/`（macOS/Linux）中查找日志文件

### 安装错误
- **Windows 安装程序**：确保您对安装目录有写入权限
- **包管理器**：检查您的互联网连接并重试
- **便携式版本**：确保您已正确提取所有文件

### 性能问题
- **关闭其他应用程序**：释放系统资源
- **增加内存**：考虑升级系统内存
- **降低显示分辨率**：调整您的显示设置

## 卸载

### Windows（安装程序）
1. 转到 `控制面板` > `程序` > `程序和功能`
2. 从列表中选择 "AVA AIGC 工具箱"
3. 点击 "卸载" 并按照说明操作

### macOS（Homebrew）
```bash
brew uninstall ava-aigc-toolbox
```

### Linux（Snap）
```bash
sudo snap remove ava-aigc-toolbox
```

### 便携式版本
- 只需删除提取的目录
- 可选地删除应用程序数据文件夹：
  - Windows：`%APPDATA%/AIGenManager/`
  - macOS：`~/.local/share/AIGenManager/`
  - Linux：`~/.local/share/AIGenManager/`

## 下一步

- [快速开始指南](./getting-started.md)
- [功能概述](./features.md)
- [用户界面指南](./ui-guide.md)

如果您在安装过程中遇到任何问题，请查看 [常见问题](./faq.md) 或在 GitHub 问题页面上报告。