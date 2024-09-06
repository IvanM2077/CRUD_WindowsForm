# Windows Forms Database Manager

## Descripción

Esta aplicación está diseñada en **Windows Forms** y permite gestionar una base de datos mediante operaciones de **lectura**, **alta**, **baja** y **actualización**. Se utiliza **SQLite** como motor de base de datos y se aplica el principio **Singleton**, garantizando una única instancia de la conexión a la base de datos a lo largo de toda la ejecución de la aplicación.

## Características

- **Operaciones CRUD** (Create, Read, Update, Delete) sobre una base de datos SQLite.
- Interfaz gráfica intuitiva usando controles de Windows Forms:
  - **DataGridView** para visualizar los datos.
  - **TextBox** para introducir y editar información.
  - **Botones** para ejecutar las acciones CRUD.
- Implementación del patrón **Singleton** para la gestión de la conexión a la base de datos.
- Integración con **SQLite** usando **SQLiteClient**.

## Tecnologías Utilizadas

- **C#**
- **Windows Forms**
- **SQLite**
- **SQLiteClient**

## Estructura del Proyecto

- **MainForm.cs**: Contiene la lógica principal de la interfaz gráfica y la interacción del usuario.
- **DatabaseHelper.cs**: Implementa el acceso a la base de datos utilizando el patrón Singleton.
- **Models/**: Contiene las clases que representan las entidades del sistema.

## Instalación

1. Clona este repositorio en tu máquina local:
    ```bash
    git clone https://github.com/tu-repo/windows-forms-database-manager.git
    ```

2. Abre el archivo del proyecto en **Visual Studio**.

3. Asegúrate de que tienes instaladas las siguientes dependencias:
    - **SQLite**: Puedes añadir la biblioteca **System.Data.SQLite** desde NuGet.
    - **.NET Framework 4.7.2** (o superior).

4. Ejecuta el proyecto desde Visual Studio.

## Uso

1. **Agregar datos**: Introduce la información en los campos de texto y presiona el botón "Agregar" para añadir un nuevo registro a la base de datos.
2. **Actualizar datos**: Selecciona un registro desde el `DataGridView`, edita los campos y presiona "Actualizar" para guardar los cambios.
3. **Eliminar datos**: Selecciona un registro y presiona el botón "Eliminar" para eliminarlo de la base de datos.
4. **Visualizar datos**: Los datos de la base de datos se mostrarán automáticamente en el `DataGridView`.

## Singleton (Patrón de Diseño)

La aplicación implementa el patrón **Singleton** para asegurar que solo exista una instancia de la clase de acceso a la base de datos. Esto mejora el rendimiento y evita múltiples conexiones innecesarias.
