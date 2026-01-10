# Visión General de la Interfaz

> **La versión en inglés es la válida**

AVA AIGC Toolbox cuenta con una interfaz de usuario intuitiva y bien organizada diseñada para ayudarte a gestionar tus imágenes generadas por IA de manera eficiente. Esta guía proporciona una explicación detallada de todos los componentes principales de la interfaz.

## Diseño de la Ventana Principal

La ventana de la aplicación se divide en cinco secciones principales:

1. **Barra de Menú** - Navegación de nivel superior y comandos de la aplicación
2. **Barra Lateral** - Acceso rápido a diferentes vistas y filtros
3. **Barra de Herramientas** - Acciones comunes y configuraciones
4. **Área de Contenido Principal** - Visualización de imágenes y detalles
5. **Barra de Estado** - Estado de la aplicación y información

```
┌─────────────────────────────────────────────────────────────────�?�?                       Barra de Menú                             �?├─────────────────────────────────────────────────────────────────�?�?                       Barra de Herramientas                        �?├───────────────┬─────────────────────────────────────────────────�?�?              �?                                                �?�?  Barra Lateral  �?             Área de Contenido Principal          �?�?              �?                                                �?├───────────────┴─────────────────────────────────────────────────�?�?                       Barra de Estado                             �?└─────────────────────────────────────────────────────────────────�?```

## 1. Barra de Menú

La barra de menú contiene comandos y configuraciones globales de la aplicación, organizados en los siguientes menús:

### Menú Archivo
- **Nueva Biblioteca**: Crea una nueva biblioteca de imágenes vacía
- **Abrir Biblioteca**: Abre una base de datos de biblioteca existente
- **Importar**: 
  - **Importar Imágenes**: Importar imágenes desde carpetas
  - **Importar Metadatos**: Importar metadatos desde archivos
- **Exportar**: 
  - **Exportar Imágenes Seleccionadas**: Exportar imágenes seleccionadas a una carpeta
  - **Exportar Todas las Imágenes**: Exportar todas las imágenes en la vista actual
- **Configuración**: Abrir configuraciones de la aplicación
- **Salir**: Cerrar la aplicación

### Menú Editar
- **Deshacer**: Deshacer la última acción
- **Rehacer**: Rehacer la última acción deshecha
- **Seleccionar Todo**: Seleccionar todas las imágenes en la vista actual
- **Deseleccionar Todo**: Deseleccionar todas las imágenes seleccionadas
- **Invertir Selección**: Invertir la selección actual
- **Buscar**: Abrir el diálogo de búsqueda

### Menú Ver
- **Alternar Barra Lateral**: Mostrar o ocultar la barra lateral
- **Alternar Panel de Detalles**: Mostrar o ocultar el panel de detalles
- **Modo de Vista**: 
  - **Vista de Cuadrícula**: Mostrar imágenes en una cuadrícula
  - **Vista de Lista**: Mostrar imágenes en una lista con detalles
- **Ordenar Por**: Cambiar el orden de clasificación de las imágenes
- **Zoom**: Ajustar el nivel de zoom de la cuadrícula de imágenes
- **Actualizar**: Actualizar la vista actual

### Menú Herramientas
- **Operaciones por Lote**: 
  - **Renombrar por Lote**: Renombrar múltiples imágenes a la vez
  - **Etiquetar por Lote**: Agregar etiquetas a múltiples imágenes
  - **Exportar por Lote**: Exportar múltiples imágenes con configuraciones personalizadas
- **Editor de Metadatos**: Abrir herramientas avanzadas de edición de metadatos
- **Herramientas de Imágenes**: 
  - **Recortar**: Recortar imágenes
  - **Redimensionar**: Redimensionar imágenes
  - **Convertir Formato**: Convertir imágenes a diferentes formatos
- **Herramientas de IA**: 
  - **Auto-Etiquetar**: Usar IA para etiquetar automáticamente las imágenes
  - **Generar Miniaturas**: Regenerar miniaturas para todas las imágenes

### Menú Ayuda
- **Documentación**: Abrir esta documentación
- **Atajos de Teclado**: Mostrar atajos de teclado
- **Acerca de**: Mostrar versión de la aplicación y créditos
- **Verificar Actualizaciones**: Verificar nuevas versiones
- **Reportar Problema**: Abrir página de issues de GitHub

## 2. Barra Lateral

La barra lateral proporciona acceso rápido a diferentes vistas y funciones organizativas:

### Vista de Carpetas
- **Carpetas Raíz**: Muestra las carpetas raíz que has agregado a tu biblioteca
- **Subcarpetas**: Expande las carpetas para ver su contenido
- **Agregar Carpeta**: Haz clic en el botón `+` para agregar una nueva carpeta raíz
- **Opciones de Carpeta**: Haz clic con el botón derecho en una carpeta para acceder a opciones como:
  - Actualizar Carpeta
  - Eliminar Carpeta
  - Propiedades

### Vista de Álbumes
- **Mis Álbumes**: Muestra todos los álbumes creados por el usuario
- **Agregar Álbum**: Haz clic en el botón `+` para crear un nuevo álbum
- **Opciones de Álbum**: Haz clic con el botón derecho en un álbum para acceder a opciones como:
  - Renombrar Álbum
  - Eliminar Álbum
  - Agregar Imágenes
  - Propiedades

### Vista de Etiquetas
- **Todas las Etiquetas**: Muestra todas las etiquetas en tu biblioteca, ordenadas por uso
- **Nube de Etiquetas**: Representación visual de etiquetas por popularidad
- **Agregar Etiqueta**: Haz clic en el botón `+` para crear una nueva etiqueta
- **Opciones de Etiqueta**: Haz clic con el botón derecho en una etiqueta para acceder a opciones como:
  - Renombrar Etiqueta
  - Eliminar Etiqueta
  - Fusionar Etiquetas
  - Ver Imágenes con Etiqueta

### Colecciones Inteligentes
- **Todas las Imágenes**: Todas las imágenes en tu biblioteca
- **Favoritos**: Imágenes marcadas como favoritas
- **Recientemente Agregadas**: Imágenes agregadas en los últimos 30 días
- **Recientemente Vistas**: Imágenes vistas en los últimos 7 días
- **Imágenes Sin Etiquetas**: Imágenes sin ninguna etiqueta
- **Para Eliminar**: Imágenes marcadas para eliminación

## 3. Barra de Herramientas

La barra de herramientas proporciona acceso rápido a acciones comunes y configuraciones:

### Barra de Herramientas Principal
- **Importar**: Importar imágenes desde carpetas
- **Actualizar**: Actualizar la vista actual
- **Modo de Vista**: Alternar entre vistas de cuadrícula y lista
- **Ordenar**: Cambiar el orden de clasificación (por nombre, fecha, tamaño, etc.)
- **Filtrar**: Abrir el panel de filtro
- **Configuración**: Abrir configuraciones de la aplicación

### Barra de Herramientas de Operaciones de Imágenes
- **Favorito**: Marcar/desmarcar imágenes seleccionadas como favoritas
- **Eliminar**: Eliminar imágenes seleccionadas
- **Etiquetar**: Agregar etiquetas a imágenes seleccionadas
- **Editar**: Abrir editor de imágenes
- **Exportar**: Exportar imágenes seleccionadas

## 4. Área de Contenido Principal

El área de contenido principal muestra imágenes y sus detalles, y consta de dos partes:

### Visualización de Imágenes

#### Vista de Cuadrícula
- **Miniaturas de Imágenes**: Muestra imágenes en una cuadrícula de miniaturas
- **Selección**: 
  - Haz clic para seleccionar una sola imagen
  - Ctrl/Cmd + Clic para seleccionar múltiples imágenes
  - Shift + Clic para seleccionar un rango de imágenes
  - Arrastra para seleccionar múltiples imágenes en un área rectangular
- **Información de Imagen**: Muestra información básica al pasar el mouse (nombre de archivo, dimensiones, tamaño)

#### Vista de Lista
- **Columnas**: Muestra imágenes con columnas para:
  - Nombre de archivo
  - Tamaño
  - Dimensiones
  - Fecha de Adición
  - Fecha de Modificación
  - Calificación
  - Estado de favorito
- **Ordenación**: Haz clic en los encabezados de columna para ordenar por esa columna
- **Columnas Redimensionables**: Arrastra los divisores de columnas para ajustar los anchos

#### Vista de Pantalla Completa
- **Doble Clic**: Abrir una imagen en vista de pantalla completa
- **Navegación**: 
  - Teclas de flecha para navegar entre imágenes
  - Esc para salir del modo de pantalla completa
  - Clic derecho para opciones adicionales
- **Zoom**: Usa la rueda del mouse para acercar/alejar
- **Pan**: Haz clic y arrastra para desplazarte cuando estés acercado

### Panel de Detalles

El panel de detalles aparece en el lado derecho de la ventana cuando se selecciona una imagen, mostrando información detallada sobre la imagen:

#### Información Básica
- **Nombre de Archivo**: Nombre del archivo de imagen
- **Ruta**: Ruta completa del archivo
- **Tamaño**: Tamaño del archivo en bytes/KB/MB
- **Dimensiones**: Ancho y alto en píxeles
- **Resolución**: Información DPI (si está disponible)
- **Formato**: Formato de archivo (JPEG, PNG, etc.)
- **Fecha de Adición**: Cuando se agregó la imagen a la biblioteca
- **Fecha de Modificación**: Última fecha de modificación del archivo

#### Metadatos de IA
- **Prompt**: El prompt utilizado para generar la imagen
- **Prompt Negativo**: El prompt negativo utilizado
- **Pasos**: Número de pasos de generación
- **Muestreo**: Nombre del muestreo utilizado
- **Escala CFG**: Valor de escala CFG
- **Seed**: Valor de seed utilizado para la generación
- **Modelo**: Nombre del modelo utilizado
- **Hash del Modelo**: Hash del modelo
- **Ancho/Alto**: Dimensiones generadas

#### Propiedades de Imagen
- **Calificación**: Sistema de calificación de 1-5 estrellas
- **Favorito**: Alternar estado de favorito
- **Para Eliminar**: Marcar para eliminación
- **NSFW**: Marcar como No Seguro para el Trabajo
- **No Disponible**: El archivo no está disponible

#### Etiquetas
- **Lista de Etiquetas**: Mostrar todas las etiquetas asociadas con la imagen
- **Agregar Etiqueta**: Haz clic en `+` para agregar nuevas etiquetas
- **Eliminar Etiqueta**: Haz clic en `×` para eliminar etiquetas existentes

## 5. Barra de Estado

La barra de estado aparece en la parte inferior de la ventana y muestra:

- **Total de Imágenes**: Número de imágenes en la vista actual
- **Imágenes Seleccionadas**: Número de imágenes seleccionadas
- **Estado de Filtro**: Filtro actualmente aplicado
- **Estado de Clasificación**: Criterios de clasificación actuales
- **Estado de la Aplicación**: Actividad actual de la aplicación (importando, exportando, etc.)
- **Tamaño de la Base de Datos**: Tamaño de la base de datos actual

## 6. Diálogos y Paneles

### Diálogo de Importación
- **Selección de Carpeta**: Elegir carpetas desde donde importar imágenes
- **Opciones de Importación**: 
  - Incluir subcarpetas
  - Sobrescribir imágenes existentes
  - Extraer metadatos
  - Generar miniaturas
- **Indicador de Progreso**: Muestra el progreso de la importación

### Diálogo de Exportación
- **Carpeta de Destino**: Elegir dónde exportar las imágenes
- **Opciones de Exportación**: 
  - Incluir metadatos
  - Redimensionar imágenes
  - Convertir a formato
  - Renombrar archivos
- **Indicador de Progreso**: Muestra el progreso de la exportación

### Panel de Filtro
- **Búsqueda de Texto**: Buscar por nombre de archivo, etiquetas o metadatos
- **Rango de Fechas**: Filtrar por fecha de creación o modificación
- **Dimensiones**: Filtrar por ancho y alto de la imagen
- **Calificación**: Filtrar por calificación de estrellas
- **Etiquetas**: Filtrar por etiquetas específicas
- **Metadatos de IA**: Filtrar por modelo, muestreo, pasos, etc.

### Diálogo de Configuración
- **General**: Idioma de la aplicación, tema y opciones de inicio
- **Biblioteca**: Ubicación de la base de datos y configuraciones de copia de seguridad
- **Importación**: Opciones de importación por defecto
- **Visualización**: Tamaño de miniatura, espaciado de cuadrícula y opciones de vista
- **Metadatos**: Opciones de extracción y visualización de metadatos
- **Atajos de Teclado**: Personalizar atajos de teclado

## 7. Menús Contextuales

Los menús contextuales aparecen cuando haces clic con el botón derecho en varios elementos:

### Menú Contextual de Imagen
- **Ver**: Abrir en vista de pantalla completa
- **Editar**: Editar imagen o metadatos
- **Copiar**: Copiar imagen al portapapeles
- **Mover a**: Mover imagen a otra carpeta o álbum
- **Copiar a**: Copiar imagen a otra ubicación
- **Eliminar**: Eliminar imagen de la biblioteca
- **Agregar a Álbum**: Agregar a álbum existente
- **Agregar Etiquetas**: Agregar etiquetas a la imagen
- **Eliminar Etiquetas**: Eliminar etiquetas de la imagen
- **Establecer Calificación**: Establecer calificación de estrellas
- **Marcar como Favorito**: Alternar estado de favorito
- **Propiedades**: Ver propiedades detalladas

### Menú Contextual de Carpeta
- **Abrir en Explorador/Finder**: Abrir carpeta en el gestor de archivos del sistema
- **Actualizar**: Actualizar el contenido de la carpeta
- **Eliminar Carpeta**: Eliminar de la biblioteca (no borra archivos)
- **Propiedades**: Ver propiedades de la carpeta

### Menú Contextual de Álbum
- **Abrir**: Ver el contenido del álbum
- **Renombrar**: Renombrar el álbum
- **Eliminar**: Eliminar el álbum
- **Agregar Imágenes**: Agregar imágenes al álbum
- **Eliminar Imágenes**: Eliminar imágenes seleccionadas del álbum
- **Propiedades**: Ver propiedades del álbum

### Menú Contextual de Etiqueta
- **Ver Imágenes**: Ver todas las imágenes con esta etiqueta
- **Renombrar**: Renombrar la etiqueta
- **Eliminar**: Eliminar la etiqueta
- **Fusionar Con**: Fusionar con otra etiqueta
- **Propiedades**: Ver propiedades de la etiqueta

## 8. Atajos de Teclado

Para un acceso rápido a comandos comunes, consulta la referencia de [Atajos de Teclado](./keyboard-shortcuts.md).

## Opciones de Personalización

### Tema
- **Modo Claro**: Esquema de colores claro
- **Modo Oscuro**: Esquema de colores oscuro
- **Tema del Sistema**: Seguir las configuraciones de tema del sistema

### Opciones de Visualización
- **Tamaño de Miniatura**: Ajustar el tamaño de las miniaturas en vista de cuadrícula
- **Espaciado de Cuadrícula**: Ajustar el espaciado entre imágenes en vista de cuadrícula
- **Mostrar/Ocultar Columnas**: Personalizar qué columnas aparecen en vista de lista
- **Posición del Panel de Detalles**: Mover el panel de detalles a la izquierda o derecha

### Tamaño de Fuente
- Ajustar el tamaño de la fuente para una mejor legibilidad

## Consejos para una Navegación Eficiente

1. **Navegación por Teclado**: Usa atajos de teclado para una operación más rápida
2. **Personaliza la Barra de Herramientas**: Agrega comandos frecuentemente usados a la barra de herramientas
3. **Ancla Elementos Frecuentes**: Ancla carpetas, álbumes y etiquetas frecuentemente usados en la parte superior de sus listas respectivas
4. **Usa Colecciones Inteligentes**: Aprovecha las colecciones inteligentes preconstruidas para un acceso rápido
5. **Filtros Personalizados**: Crea y guarda filtros personalizados para búsquedas recurrentes
6. **Enfoque del Teclado**: Presiona `Tab` para navegar entre elementos de la interfaz
7. **Menús Contextuales**: Haz clic con el botón derecho en elementos para un acceso rápido a opciones

## Conclusión

La interfaz de usuario de AVA AIGC Toolbox está diseñada para ser intuitiva y eficiente, con todas las funciones fácilmente accesibles desde la interfaz principal. Al familiarizarte con los diferentes componentes, podrás navegar y usar la aplicación de manera más efectiva, ayudándote a gestionar tus imágenes generadas por IA con facilidad.

Para obtener más información sobre funciones específicas, consulta las secciones relevantes en esta documentación: