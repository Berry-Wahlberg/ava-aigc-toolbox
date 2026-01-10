# Guía de Instalación

> **La versión en inglés es la válida**

## Visión General
Esta guía lo guiará a través del proceso de instalación de AVA AIGC Toolbox en su sistema. La aplicación admite Windows, macOS y Linux.

## Requisitos del Sistema

### Requisitos Mínimos
- **Sistema Operativo**: Windows 10+, macOS 10.15+ o Linux (Ubuntu 20.04+, Fedora 32+)
- **Entorno .NET**: .NET 7.0 o posterior
- **Espacio en Disco**: 100 MB de espacio libre
- **RAM**: 2 GB como mínimo

### Requisitos Recomendados
- **RAM**: 4 GB o más
- **Procesador**: CPU de múltiples núcleos
- **Pantalla**: Resolución 1080p o superior

## Métodos de Instalación

### 1. Usando el Instalador (Windows)

1. **Descargar el Instalador**
   - Visite el sitio web oficial o la página de lanzamientos de GitHub
   - Descargue el último instalador `.exe` para Windows

2. **Ejecutar el Instalador**
   - Haga doble clic en el archivo `.exe` descargado
   - Siga las instrucciones en pantalla
   - Elija el directorio de instalación (se recomienda el valor predeterminado)
   - Seleccione si desea crear accesos directos en el escritorio y el menú de inicio

3. **Lanzar la Aplicación**
   - Haga clic en "Finalizar" para lanzar la aplicación inmediatamente
   - O use los accesos directos del escritorio/menú de inicio más tarde

### 2. Usando el Gestor de Paquetes (macOS/Linux)

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

### 3. Versión Portátil (Todas las Plataformas)

1. **Descargar el Archivo Portátil**
   - Descargue el último archivo `.zip` (Windows) o `.tar.gz` (macOS/Linux)

2. **Extraer el Archivo**
   - Extraiga el contenido en un directorio de su elección
   - No se requiere instalación

3. **Ejecutar la Aplicación**
   - Windows: Haga doble clic en `AIGenManager.exe`
   - macOS/Linux: Ejecute `./AIGenManager` desde la terminal

## Instalación del Entorno .NET

Si no tiene instalado el entorno .NET 7.0, deberá instalarlo primero:

### Windows
- Descargue desde https://dotnet.microsoft.com/download/dotnet/7.0
- Ejecute el instalador y siga las instrucciones

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

## Verificando la Instalación

1. **Lanzar la Aplicación**
2. **Verificar la Versión**
   - Vaya a `Ayuda` > `Acerca de`
   - Verifique que la versión coincida con la que descargó

3. **Probar la Funcionalidad Básica**
   - La aplicación debe lanzarse sin errores
   - La ventana principal debe mostrarse correctamente
   - Debe poder navegar por la interfaz

## Solución de Problemas

### La Aplicación No Se Inicia
- **Verificar el Entorno .NET**: Asegúrese de tener instalado el entorno .NET correcto
- **Verificar los Requisitos del Sistema**: Verifique que su sistema cumpla con los requisitos mínimos
- **Ejecutar como Administrador**: Intente ejecutar la aplicación con privilegios de administrador
- **Verificar los Registros**: Busque archivos de registro en `%APPDATA%/AIGenManager/` (Windows) o `~/.local/share/AIGenManager/` (macOS/Linux)

### Errores de Instalación
- **Instalador de Windows**: Asegúrese de tener permisos de escritura en el directorio de instalación
- **Gestor de Paquetes**: Verifique su conexión a Internet y vuelva a intentarlo
- **Versión Portátil**: Asegúrese de haber extraído todos los archivos correctamente

### Problemas de Rendimiento
- **Cerrar Otras Aplicaciones**: Libere recursos del sistema
- **Aumentar la RAM**: Considere actualizar la RAM de su sistema
- **Reducir la Resolución de Pantalla**: Ajuste sus configuraciones de pantalla

## Desinstalación

### Windows (Instalador)
1. Vaya a `Panel de Control` > `Programas` > `Programas y características`
2. Seleccione "AVA AIGC Toolbox" de la lista
3. Haga clic en "Desinstalar" y siga las instrucciones

### macOS (Homebrew)
```bash
brew uninstall ava-aigc-toolbox
```

### Linux (Snap)
```bash
sudo snap remove ava-aigc-toolbox
```

### Versión Portátil
- Simplemente elimine el directorio extraído
- Opcionalmente, elimine la carpeta de datos de la aplicación:
  - Windows: `%APPDATA%/AIGenManager/`
  - macOS: `~/.local/share/AIGenManager/`
  - Linux: `~/.local/share/AIGenManager/`

## Pasos Siguientes

- [Guía de Primeros Pasos](./getting-started.md)
- [Visión General de las Características](./features.md)
- [Guía de la Interfaz de Usuario](./ui-guide.md)

Si encuentra algún problema durante la instalación, consulte la [FAQ](./faq.md) o informe los problemas en la página de issues de GitHub.