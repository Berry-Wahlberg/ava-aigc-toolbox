# Guia de Instalação

> **A versão em português é a oficial**

## Visão Geral
Este guia irá guiá-lo através do processo de instalação da AVA AIGC Toolbox no seu sistema. O aplicativo suporta Windows, macOS e Linux.

## Requisitos do Sistema

### Requisitos Mínimos
- **Sistema Operacional**: Windows 10+, macOS 10.15+ ou Linux (Ubuntu 20.04+, Fedora 32+)
- **Runtime .NET**: .NET 7.0 ou posterior
- **Espaço em Disco**: 100 MB de espaço livre
- **RAM**: 2 GB mínimo

### Requisitos Recomendados
- **RAM**: 4 GB ou mais
- **Processador**: CPU multi-core
- **Tela**: Resolução de 1080p ou superior

## Métodos de Instalação

### 1. Usando o Instalador (Windows)

1. **Baixar o Instalador**
   - Visite o site oficial ou a página de lançamentos do GitHub
   - Baixe o instalador `.exe` mais recente para Windows

2. **Executar o Instalador**
   - Clique duas vezes no arquivo `.exe` baixado
   - Siga as instruções na tela
   - Escolha o diretório de instalação (recomendado o padrão)
   - Selecione se deseja criar atalhos na área de trabalho e no menu Iniciar

3. **Iniciar o Aplicativo**
   - Clique em "Concluir" para iniciar o aplicativo imediatamente
   - Ou use os atalhos na área de trabalho/menu Iniciar posteriormente

### 2. Usando o Gerenciador de Pacotes (macOS/Linux)

#### macOS (Homebrew)
```bash
brew tap ava-aigc-toolbox/tap
brew install ava-aigc-toolbox
```

#### Linux (Snap)
```bash
sudo snap install ava-aigc-toolbox
```

#### Linux (Debian/Ubuntu)
```bash
sudo dpkg -i ava-aigc-toolbox_*.deb
sudo apt-get install -f
```

### 3. Versão Portátil (Todas as Plataformas)

1. **Baixar o Arquivo Compactado**
   - Baixe o arquivo compactado `.zip` mais recente (Windows) ou `.tar.gz` (macOS/Linux)

2. **Extrair o Arquivo**
   - Extraia o conteúdo para um diretório de sua escolha
   - Nenhuma instalação necessária

3. **Executar o Aplicativo**
   - Windows: Clique duas vezes em `AIGenManager.exe`
   - macOS/Linux: Execute `./AIGenManager` no terminal

## Instalação do Runtime .NET

Se você não tiver o runtime .NET 7.0 instalado, precisará instalá-lo primeiro:

### Windows
- Baixe de https://dotnet.microsoft.com/download/dotnet/7.0
- Execute o instalador e siga as instruções

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

## Verificando a Instalação

1. **Iniciar o Aplicativo**
2. **Verificar Versão**
   - Vá para `Ajuda` > `Sobre`
   - Verifique se a versão corresponde à que você baixou

3. **Testar Funcionalidades Básicas**
   - O aplicativo deve iniciar sem erros
   - A janela principal deve ser exibida corretamente
   - Você deve conseguir navegar pela interface

## Resolução de Problemas

### Aplicativo Não Inicia
- **Verificar Runtime .NET**: Certifique-se de ter o runtime .NET correto instalado
- **Verificar Requisitos do Sistema**: Verifique se seu sistema atende aos requisitos mínimos
- **Executar como Administrador**: Tente executar o aplicativo com privilégios de administrador
- **Verificar Logs**: Procure arquivos de log em `%APPDATA%/AIGenManager/` (Windows) ou `~/.local/share/AIGenManager/` (macOS/Linux)

### Erros de Instalação
- **Instalador Windows**: Certifique-se de ter permissões de gravação no diretório de instalação
- **Gerenciador de Pacotes**: Verifique sua conexão com a internet e tente novamente
- **Versão Portátil**: Certifique-se de ter extraído todos os arquivos corretamente

### Problemas de Desempenho
- **Fechar Outros Aplicativos**: Libere recursos do sistema
- **Aumentar RAM**: Considere atualizar a RAM do seu sistema
- **Reduzir Resolução da Tela**: Ajuste as configurações de exibição

## Desinstalação

### Windows (Instalador)
1. Vá para `Painel de Controle` > `Programas` > `Programas e Recursos`
2. Selecione "AVA AIGC Toolbox" da lista
3. Clique em "Desinstalar" e siga as instruções

### macOS (Homebrew)
```bash
brew uninstall ava-aigc-toolbox
```

### Linux (Snap)
```bash
sudo snap remove ava-aigc-toolbox
```

### Versão Portátil
- Simplesmente exclua o diretório extraído
- Opcionalmente, exclua a pasta de dados do aplicativo:
  - Windows: `%APPDATA%/AIGenManager/`
  - macOS: `~/.local/share/AIGenManager/`
  - Linux: `~/.local/share/AIGenManager/`

## Próximos Passos

- [Guia de Primeiros Passos](./getting-started.md)
- [Visão Geral das Funcionalidades](./features.md)
- [Guia da Interface do Usuário](./ui-guide.md)

Se você encontrar qualquer problema durante a instalação, consulte o [FAQ](./faq.md) ou relate-os na página de issues do GitHub.