# Configuraciones

> **La versión en inglés es la válida**

AVA AIGC Toolbox proporciona un conjunto completo de configuraciones para personalizar tu experiencia. Esta guía cubre todas las configuraciones disponibles y cómo configurarlas.

## Accediendo a las Configuraciones

#### Pasos para abrir las configuraciones:
1. Haz clic en el botón **Configuración** en la barra de herramientas, o ve a `Archivo > Configuración`
2. Aparecerá la ventana de configuraciones
3. Usa la barra lateral para navegar entre diferentes categorías de configuraciones
4. Haz clic en **Guardar** para aplicar cambios, o **Cancelar** para descartar cambios
5. Algunas configuraciones pueden requerir reiniciar la aplicación para que surtan efecto

## Configuraciones Generales

### Aplicación
- **Idioma**: Selecciona el idioma de la aplicación (Inglés, etc.)
- **Tema**: Elige entre tema claro, oscuro o del sistema
- **Comportamiento al Iniciar**: Configura lo que sucede cuando la aplicación se inicia
  - **Mostrar Pantalla de Bienvenida**: Mostrar pantalla de bienvenida al iniciar
  - **Abrir Última Biblioteca**: Abrir automáticamente la última biblioteca utilizada
  - **Minimizar a la Bandeja**: Iniciar minimizado en la bandeja del sistema
- **Verificaciones de Actualización**: Configurar verificaciones automáticas de actualizaciones
  - **Verificar actualizaciones automáticamente**: Activar/desactivar verificaciones automáticas de actualizaciones
  - **Canal de actualización**: Seleccionar canal de actualización (stable, beta, nightly)

### Interfaz
- **Tamaño de Fuente**: Ajusta el tamaño de fuente de la aplicación para una mejor legibilidad
- **Tamaño de Íconos**: Cambia el tamaño de los íconos en la interfaz
- **Animación**: Activar/desactivar animaciones
- **Ayudas de Pantalla**: Activar/desactivar ayudas de pantalla
- **Barra de Estado**: Mostrar/ocultar la barra de estado

## Configuraciones de Biblioteca

### General
- **Ubicación de la Base de Datos**: Ruta al archivo de base de datos de la biblioteca
- **Carpeta de Importación Predeterminada**: Carpeta predeterminada para importar imágenes
- **Actualizar Automáticamente la Biblioteca**: Actualizar automáticamente la biblioteca cuando los archivos cambien
- **Observador de Archivos**: Activar/desactivar la observación del sistema de archivos

### Copia de Seguridad
- **Activar copia de seguridad automática**: Activar/desactivar copias de seguridad programadas
- **Frecuencia de Copia de Seguridad**: Con qué frecuencia hacer copias de seguridad (diaria, semanal, mensual)
- **Hora de Copia de Seguridad**: Hora del día para realizar copias de seguridad
- **Tipo de Copia de Seguridad**: Solo base de datos o copia de seguridad completa
- **Carpeta de Destino**: Donde almacenar las copias de seguridad
- **Conservar Copias de Seguridad Durante**: Cuánto tiempo conservar las copias de seguridad antiguas
- **Número Máximo de Copias de Seguridad**: Número máximo de copias de seguridad a conservar

### Rendimiento
- **Tamaño del Caché de Miniaturas**: Tamaño máximo del caché de miniaturas en MB
- **Tamaño del Caché de Imágenes**: Tamaño máximo del caché de imágenes en MB
- **Procesamiento Paralelo**: Número de procesos paralelos para tareas
- **Carga Perezosa**: Activar/desactivar la carga perezosa de imágenes

## Configuraciones de Importación

### General
- **Incluir Subcarpetas**: Incluir subcarpetas durante la importación por defecto
- **Extraer Metadatos**: Extraer metadatos de imágenes por defecto
- **Generar Miniaturas**: Generar miniaturas durante la importación por defecto
- **Sobrescribir Existentes**: Sobrescribir imágenes existentes por defecto

### Manejo de Archivos
- **Ignorar Archivos Corruptos**: Ignorar archivos corruptos durante la importación
- **Ignorar Archivos Duplicados**: Ignorar archivos con la misma ruta
- **Resolución de Conflictos de Nombres de Archivos**: Cómo manejar conflictos de nombres de archivos
  - **Renombrar Nuevo Archivo**: Renombrar el nuevo archivo con un sufijo
  - **Sobrescribir Existente**: Reemplazar el archivo existente
  - **Ignorar**: Ignorar el nuevo archivo

## Configuraciones de Visualización

### Vista de Cuadrícula
- **Tamaño de Miniatura Predeterminado**: Tamaño predeterminado de miniaturas en vista de cuadrícula
- **Espaciado de Cuadrícula**: Espaciado entre imágenes en vista de cuadrícula
- **Mostrar Nombres de Archivos**: Mostrar/ocultar nombres de archivos bajo las miniaturas
- **Mostrar Estrellas de Calificación**: Mostrar/ocultar estrellas de calificación en las miniaturas
- **Mostrar Ícono de Favorito**: Mostrar/ocultar ícono de favorito en las miniaturas

### Vista de Lista
- **Columnas Predeterminadas**: Selecciona qué columnas mostrar por defecto en vista de lista
- **Anchos de Columnas**: Ajustar los anchos predeterminados para columnas
- **Altura de Filas**: Establecer la altura de filas en vista de lista

### Panel de Detalles
- **Mostrar Panel de Detalles**: Mostrar/ocultar el panel de detalles por defecto
- **Posición del Panel**: Posición del panel de detalles (izquierda, derecha, inferior)
- **Secciones Expandidas**: Qué secciones mostrar expandidas por defecto

## Configuraciones de Metadatos

### Extracción
- **Extraer Metadatos al Importar**: Extraer automáticamente metadatos al importar imágenes
- **Campos de Metadatos**: Seleccionar qué campos de metadatos extraer
- **Asignación de Nombres de Modelos**: Asignar hashes de modelos a nombres legibles por humanos
- **Detectar Automáticamente el Modelo**: Detectar automáticamente nombres de modelos desde metadatos

### Visualización
- **Mostrar Prompt Completo**: Mostrar prompt completo o truncado en el panel de detalles
- **Formato de Fechas**: Seleccionar formato de fecha (corto, largo, personalizado)
- **Formato de Números**: Seleccionar opciones de formato de números

### Edición
- **Permitir Edición de Metadatos**: Activar/desactivar edición de metadatos
- **Validar Metadatos**: Validar metadatos antes de guardar
- **Copiar de Seguridad de Metadatos Originales**: Guardar una copia de seguridad de metadatos originales antes de editar

## Configuraciones de IA

### General
- **Activar Funcionalidades IA**: Activar/desactivar funcionalidades IA
- **Modelo IA Predeterminado**: Establecer el modelo IA predeterminado para diversas tareas
- **Max de Solicitudes Paralelas**: Número de solicitudes IA paralelas
- **Almacenar Resultados IA en Caché**: Almacenar resultados IA en caché para un procesamiento más rápido

### Modelos de Etiquetado
- **Modelo de Etiquetado Predeterminado**: Establecer el modelo predeterminado para auto-etiquetado
- **Umbral de Confianza para Etiquetas**: Nivel de confianza predeterminado para etiquetas generadas
- **Idioma de Etiquetas**: Idioma predeterminado para etiquetas generadas

### Integración API
- **Clave API**: Tu clave API para servicios IA
- **URL API**: URL del punto final API
- **Límite de Tasa**: Número máximo de solicitudes por minuto
- **Tiempo de Espera**: Tiempo de espera de solicitudes API en segundos

## Configuraciones de Búsqueda

### General
- **Ámbito de Búsqueda Predeterminado**: Ámbito predeterminado para búsquedas (todas las imágenes, carpeta actual, etc.)
- **Tamaño del Historial de Búsqueda**: Número de búsquedas recientes a mantener
- **Auto-completar**: Activar/desactivar auto-completar de búsqueda
- **Jokers Activados**: Activar/desactivar jokers en la búsqueda

### Avanzado
- **Indexación de Búsqueda**: Configurar el comportamiento de indexación de búsqueda
  - **Indexar al Importar**: Indexar imágenes al importarlas
  - **Indexar en Segundo Plano**: Indexar imágenes en segundo plano
  - **Frecuencia de Indexación**: Con qué frecuencia actualizar el índice de búsqueda

## Configuraciones de Exportación

### Valores Predeterminados
- **Formato de Exportación Predeterminado**: Formato predeterminado para exportar imágenes
- **Calidad de Exportación Predeterminada**: Calidad predeterminada para exportación
- **Opciones de Redimensionamiento Predeterminadas**: Configuraciones de redimensionamiento predeterminadas
- **Incluir Metadatos**: Incluir metadatos en exportaciones por defecto

### Preajustes
- **Gestionar Preajustes de Exportación**: Crear, editar y eliminar preajustes de exportación
- **Preajuste de Exportación Predeterminado**: Establecer el preajuste de exportación predeterminado

## Atajos de Teclado

### Personalización
- **Activar Atajos de Teclado**: Activar/desactivar atajos de teclado
- **Personalizar Atajos**: Modificar atajos de teclado existentes
- **Restablecer a Valores Predeterminados**: Restaurar atajos de teclado a valores por defecto

## Configuraciones de Solución de Problemas

### Registro
- **Nivel de Registro**: Establecer el nivel de detalle de los registros (debug, info, warning, error)
- **Ubicación del Archivo de Registro**: Ruta a los archivos de registro
- **Tamaño Máximo de Archivos de Registro**: Tamaño máximo de archivos de registro en MB
- **Conservar Archivos de Registro Durante**: Cuánto tiempo conservar archivos de registro

### Debug
- **Activar Modo Debug**: Activar modo debug para solución de problemas
- **Mostrar Información de Debug**: Mostrar información de debug en la interfaz
- **Generar Informes de Debug**: Crear informes de debug para soporte

## Restableciendo Configuraciones

### Restablecer a Valores Predeterminados
1. Ve a `Configuración > Avanzado > Restablecer Configuraciones`
2. Haz clic en **Restablecer a Valores Predeterminados**
3. Confirma el restablecimiento en la ventana
4. La aplicación se reiniciará con configuraciones predeterminadas

### Restablecer Configuraciones Específicas
1. Ve a la categoría de configuraciones que quieres restablecer
2. Haz clic en el botón **Restablecer a Valores Predeterminados** en la parte inferior de la página
3. Confirma el restablecimiento en la ventana
4. Haz clic en **Guardar** para aplicar cambios

## Importando/Exportando Configuraciones

### Exportar Configuraciones
1. Ve a `Configuración > Avanzado > Importar/Exportar Configuraciones`
2. Haz clic en **Exportar Configuraciones**
3. Elige una ubicación para guardar el archivo de configuraciones
4. Haz clic en **Guardar** para exportar configuraciones

### Importar Configuraciones
1. Ve a `Configuración > Avanzado > Importar/Exportar Configuraciones`
2. Haz clic en **Importar Configuraciones**
3. Selecciona el archivo de configuraciones desde tu sistema de archivos
4. Haz clic en **Abrir** para importar configuraciones
5. Reinicia la aplicación para que los cambios surtan efecto

## Mejores Prácticas para Configuraciones

1. **Comienza con Valores Predeterminados**: Empieza con configuraciones predeterminadas y ajusta según sea necesario
2. **Copia de Seguridad de Configuraciones**: Exporta tus configuraciones después de hacer cambios significativos
3. **Prueba los Cambios**: Prueba los cambios de configuraciones antes de confiar en ellos
4. **Reinicia Cuando Se Te Solicite**: Siempre reinicia la aplicación cuando se te solicite para cambios de configuraciones
5. **Documenta Configuraciones Personalizadas**: Mantén un registro de las configuraciones personalizadas que has hecho
6. **Usa Preajustes**: Guarda configuraciones frecuentemente usadas como preajustes
7. **Optimiza el Rendimiento**: Ajusta las configuraciones de rendimiento basadas en tu sistema
8. **Restablece si Ocurren Problemas**: Si encuentras problemas, intenta restablecer a configuraciones predeterminadas

## Solución de Problemas de Configuraciones

### Las Configuraciones No Se Guardan
- **Verifica los Permisos**: Asegúrate de tener permisos de escritura en la ubicación del archivo de configuraciones
- **Verifica el Espacio en Disco**: Asegúrate de que haya suficiente espacio en disco para las configuraciones
- **Cierra Otras Instancias**: Asegúrate de que no haya otras instancias de la aplicación en ejecución
- **Restablece las Configuraciones**: Intenta restablecer las configuraciones a valores predeterminados

### La Aplicación No Inicia Después de un Cambio de Configuraciones
- **Restablece las Configuraciones Manualmente**: Elimina el archivo de configuraciones para restablecer a valores predeterminados
  - Windows: `%APPDATA%/AIGenManager/settings.json`
  - macOS: `~/.local/share/AIGenManager/settings.json`
  - Linux: `~/.local/share/AIGenManager/settings.json`
- **Reinstala la Aplicación**: Si el restablecimiento manual no funciona, reinstala la aplicación

### Problemas de Rendimiento
- **Ajusta las Configuraciones de Caché**: Aumenta el tamaño de los cachés para un mejor rendimiento
- **Reduce el Procesamiento Paralelo**: Disminuye el número de procesos paralelos
- **Desactiva la Animación**: Apaga las animaciones para un rendimiento más rápido
- **Activa la Carga Perezosa**: Activa la carga perezosa para reducir el tiempo de carga inicial

## Pasos Siguientes

- Aprende sobre los [Atajos de Teclado](./keyboard-shortcuts.md) para un acceso rápido a comandos comunes
- Lee sobre [Solución de Problemas](./troubleshooting.md) para obtener ayuda con problemas comunes
- Explora la [FAQ](./faq.md) para respuestas a preguntas frecuentes