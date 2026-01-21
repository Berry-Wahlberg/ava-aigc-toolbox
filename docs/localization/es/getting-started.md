# Guía de Primeros Pasos

> **La versión en inglés es la válida**

## Bienvenido a AVA AIGC Toolbox

¡Gracias por elegir AVA AIGC Toolbox! Esta guía le ayudará a comenzar con la aplicación y explorar sus características clave.

## Primer Inicio

### 1. Lanzar la Aplicación
- **Windows**: Haga doble clic en el acceso directo del escritorio o use el menú de inicio
- **macOS**: Abra desde la carpeta Aplicaciones o use Spotlight
- **Linux**: Lance desde el menú de aplicaciones o ejecute `ava-aigc-toolbox` en la terminal

### 2. Configuración Inicial

Cuando lance la aplicación por primera vez:

1. **Pantalla de Bienvenida**
   - Verá una pantalla de bienvenida con opciones para:
     - Comenzar con una biblioteca vacía
     - Importar imágenes existentes
     - Aprender más sobre la aplicación

2. **Elija Su Opción**
   - **Comenzar con una biblioteca vacía**: Crea una nueva base de datos para sus imágenes
   - **Importar imágenes existentes**: Le permite seleccionar carpetas para importar imágenes
   - **Aprender más**: Abre la documentación

3. **Ubicación de la Base de Datos**
   - La aplicación crea automáticamente un archivo de base de datos:
     - Windows: `%APPDATA%/AIGenManager/aigenmanager.db`
     - macOS: `~/.local/share/AIGenManager/aigenmanager.db`
     - Linux: `~/.local/share/AIGenManager/aigenmanager.db`

## Navegación Básica

La ventana principal está dividida en varias secciones:

### 1. Barra Lateral
- **Carpetas**: Navegue a través de sus carpetas de imágenes
- **Álbumes**: Acceda a sus álbumes de imágenes
- **Etiquetas**: Explore y filtre por etiquetas
- **Todas las Imágenes**: Ver todas las imágenes en su biblioteca

### 2. Área de Contenido Principal
- **Cuadrícula de Imágenes**: Muestra imágenes en un diseño de cuadrícula
- **Detalles de la Imagen**: Muestra metadatos y propiedades cuando se selecciona una imagen

### 3. Barra de Herramientas
- **Importar**: Agregue nuevas imágenes a su biblioteca
- **Ordenar**: Cambie el orden de las imágenes
- **Filtrar**: Aplique filtros a la cuadrícula de imágenes
- **Vista**: Cambie entre vistas de cuadrícula y lista

### 4. Barra de Estado
- Muestra el número total de imágenes
- Muestra los criterios de filtro o búsqueda actuales
- Muestra el estado de la aplicación

## Agregando Imágenes

### 1. Importando Imágenes

#### Desde el Sistema de Archivos
1. Haga clic en el botón **Importar** en la barra de herramientas
2. Seleccione **Importar desde Carpeta**
3. Elija la carpeta que contiene sus imágenes
4. Haga clic en **Seleccionar Carpeta** para comenzar la importación

#### Arrastrar y Soltar
1. Abra su explorador de archivos/finder
2. Seleccione una o más imágenes
3. Arrástrelas al área de contenido principal de la aplicación
4. Las imágenes se agregarán a su biblioteca

### 2. Metadatos de Imágenes

Cuando se importan imágenes, la aplicación extrae automáticamente:
- Nombre de archivo y ruta
- Tamaño del archivo y dimensiones
- Fechas de creación y modificación
- Metadatos generados por IA (si están disponibles):
  - Prompt
  - Prompt negativo
  - Pasos y muestreo
  - Escala CFG y seed
  - Información del modelo

## Organizando Imágenes

### 1. Usando Carpetas

- La aplicación refleja la estructura de carpetas de su sistema de archivos
- Navegue por las carpetas en la barra lateral para ver imágenes en ubicaciones específicas
- Las nuevas carpetas creadas en el sistema de archivos se detectarán automáticamente

### 2. Creando Álbumes

1. Haga clic en el botón **+** junto a "Álbumes" en la barra lateral
2. Ingrese un nombre para su álbum
3. Presione Enter para crear
4. Arrastre imágenes desde la cuadrícula al álbum para agregarlas

### 3. Agregando Etiquetas

#### A una sola imagen
1. Seleccione una imagen en la cuadrícula
2. En el panel de detalles, busque la sección "Etiquetas"
3. Haga clic en el botón **+**
4. Ingrese un nombre de etiqueta y presione Enter

#### A múltiples imágenes
1. Seleccione múltiples imágenes usando Ctrl/Cmd + clic
2. Haga clic con el botón derecho y seleccione **Agregar Etiquetas**
3. Ingrese nombres de etiquetas separados por comas
4. Haga clic en **Agregar** para aplicar etiquetas a todas las imágenes seleccionadas

## Trabajando con Imágenes

### 1. Visualizando Imágenes

- **Clic simple**: Seleccione una imagen para ver detalles
- **Doble clic**: Abra la imagen en vista de pantalla completa
- **Clic derecho**: Abra el menú contextual con opciones adicionales

### 2. Detalles de la Imagen

Cuando se selecciona una imagen, verá:
- Información básica (nombre de archivo, tamaño, dimensiones)
- Metadatos de IA (prompt, prompt negativo, etc.)
- Etiquetas asociadas con la imagen
- Calificación y estado de favorito

### 3. Editando Metadatos

1. Seleccione una imagen
2. En el panel de detalles, haga clic en cualquier campo editable
3. Realice sus cambios
4. Presione Enter o haga clic fuera del campo para guardar

### 4. Calificación y Favoritos

- **Calificación**: Haga clic en las estrellas en el panel de detalles para calificar una imagen (1-5 estrellas)
- **Favorito**: Haga clic en el ícono de corazón para marcar una imagen como favorita
- **Para Eliminar**: Marque imágenes para eliminarlas fácilmente más tarde

## Búsqueda y Filtrado

### 1. Búsqueda Básica

1. Escriba en la barra de búsqueda en la parte superior de la ventana
2. Los resultados aparecerán automáticamente mientras escribe
3. La búsqueda coincide con nombres de archivo, etiquetas y metadatos

### 2. Filtrado Avanzado

1. Haga clic en el botón **Filtrar** en la barra de herramientas
2. Establezca criterios de filtrado:
   - Carpeta
   - Álbum
   - Etiquetas
   - Calificación
   - Rango de fechas
   - Dimensiones
   - Metadatos de IA (modelo, muestreo, etc.)
3. Haga clic en **Aplicar** para ver los resultados filtrados

## Exportando Imágenes

### 1. Exportar una sola imagen

1. Seleccione una imagen
2. Haga clic con el botón derecho y seleccione **Exportar Imagen**
3. Elija la carpeta de destino
4. Haga clic en **Guardar**

### 2. Exportar múltiples imágenes

1. Seleccione múltiples imágenes
2. Haga clic con el botón derecho y seleccione **Exportar Imágenes Seleccionadas**
3. Elija la carpeta de destino
4. Haga clic en **Guardar**

### 3. Exportar con Metadatos

- Al exportar, puede elegir incluir metadatos
- Marque la opción "Incluir metadatos" en el cuadro de diálogo de exportación
- Los metadatos se incrustarán en las imágenes exportadas

## Pasos Siguientes

Ahora que ha aprendido los conceptos básicos, puede:

- Explorar la [Visión General de la Interfaz](./ui-overview.md) para una explicación detallada de la interfaz
- Aprender sobre la [Gestión de Imágenes](./features/image-management.md) para más detalles sobre la gestión de sus imágenes
- Leer sobre la [Organización](./features/organization.md) para aprender más sobre carpetas, álbumes y etiquetas
- Consulte la [FAQ](./faq.md) para preguntas comunes

## Consejos y Trucos

- **Atajos de Teclado**: Presione `Ctrl/Cmd + K` para ver todos los atajos de teclado
- **Operaciones por Lote**: Seleccione múltiples imágenes para realizar operaciones por lote
- **Auto-Etiquetado**: Use el auto-etiquetado impulsado por IA para sus imágenes
- **Copia de Seguridad**: Realice copias de seguridad periódicas de su archivo de base de datos para prevenir la pérdida de datos
- **Actualizar Metadatos**: Use el editor de metadatos para mantener organizada la información de sus imágenes

¡Disfrute usando AVA AIGC Toolbox para gestionar sus imágenes generadas por IA!