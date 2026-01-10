# インストールガイド

> **日本語版が公式バージョンです**

## 概要
このガイドでは、AVA AIGC ツールボックスをシステムにインストールするプロセスを説明します。このアプリケーションは Windows、macOS、Linux をサポートしています。

## システム要件

### 最小要件
- **オペレーティングシステム**：Windows 10+、macOS 10.15+ または Linux（Ubuntu 20.04+、Fedora 32+）
- **.NET ランタイム**：.NET 7.0 以降
- **ディスクスペース**：100 MB の空きスペース
- **RAM**：最小 2 GB

### 推奨要件
- **RAM**：4 GB 以上
- **プロセッサ**：マルチコア CPU
- **ディスプレイ**：1080p 以上の解像度

## インストール方法

### 1. インストーラーを使用する（Windows）

1. **インストーラーをダウンロード**
   - 公式ウェブサイトまたは GitHub リリースページを訪問
   - Windows 用の最新の `.exe` インストーラーをダウンロード

2. **インストーラーを実行**
   - ダウンロードした `.exe` ファイルをダブルクリック
   - 画面の指示に従う
   - インストールディレクトリを選択（推奨はデフォルト）
   - デスクトップとスタートメニューのショートカットを作成するかどうかを選択

3. **アプリケーションを起動**
   - "完了"をクリックしてアプリケーションを即座に起動
   - または後でデスクトップ/スタートメニューのショートカットを使用

### 2. パッケージマネージャーを使用する（macOS/Linux）

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

### 3. ポータブルバージョン（すべてのプラットフォーム）

1. **ポータブルアーカイブをダウンロード**
   - 最新の `.zip`（Windows）または `.tar.gz`（macOS/Linux）アーカイブをダウンロード

2. **アーカイブを解凍**
   - 内容を任意のディレクトリに解凍
   - インストールは不要

3. **アプリケーションを実行**
   - Windows：`AIGenManager.exe` をダブルクリック
   - macOS/Linux：ターミナルから `./AIGenManager` を実行

## .NET ランタイムのインストール

.NET 7.0 ランタイムがインストールされていない場合は、最初にインストールする必要があります：

### Windows
- https://dotnet.microsoft.com/download/dotnet/7.0 からダウンロード
- インストーラーを実行し、指示に従う

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

## インストールの確認

1. **アプリケーションを起動**
2. **バージョンを確認**
   - `ヘルプ` > `このソフトウェアについて`に移動
   - バージョンがダウンロードしたものと一致することを確認

3. **基本機能をテスト**
   - アプリケーションはエラーなく起動する必要がある
   - メインウィンドウは正しく表示される必要がある
   - インターフェイスをナビゲートできる必要がある

## トラブルシューティング

### アプリケーションが起動しない
- **.NET ランタイムを確認**：正しい .NET ランタイムがインストールされていることを確認
- **システム要件を確認**：システムが最小要件を満たしていることを確認
- **管理者として実行**：アプリケーションを管理者権限で実行してみる
- **ログを確認**：`%APPDATA%/AIGenManager/`（Windows）または `~/.local/share/AIGenManager/`（macOS/Linux）でログファイルを探す

### インストールエラー
- **Windows インストーラー**：インストールディレクトリへの書き込み権限があることを確認
- **パッケージマネージャー**：インターネット接続を確認し、再試行
- **ポータブルバージョン**：すべてのファイルが正しく解凍されていることを確認

### パフォーマンスの問題
- **他のアプリケーションを閉じる**：システムリソースを解放する
- **RAM を増やす**：システムの RAM をアップグレードすることを検討
- **ディスプレイ解像度を下げる**：ディスプレイ設定を調整

## アンインストール

### Windows（インストーラー）
1. `コントロール パネル` > `プログラム` > `プログラムと機能`に移動
2. リストから「AVA AIGC ツールボックス」を選択
3. 「アンインストール」をクリックし、指示に従う

### macOS（Homebrew）
```bash
brew uninstall ava-aigc-toolbox
```

### Linux（Snap）
```bash
sudo snap remove ava-aigc-toolbox
```

### ポータブルバージョン
- 解凍したディレクトリを単に削除
- オプションでアプリケーションデータフォルダーを削除：
  - Windows：`%APPDATA%/AIGenManager/`
  - macOS：`~/.local/share/AIGenManager/`
  - Linux：`~/.local/share/AIGenManager/`

## 次のステップ

- [始めましょう](./getting-started.md)
- [機能の概要](./features.md)
- [ユーザーインターフェイスガイド](./ui-guide.md)

インストール中に問題が発生した場合は、[FAQ](./faq.md) を確認するか、GitHub の問題ページで報告してください。