# TASK APP

Se trata de una aplicación para gestionar tareas en una familia. Los usuarios pueden pertenecer a una familia y asignarse tareas entre ellos.

## Pantallas de la Aplicación
- **Pantalla de Tareas**: Crear, editar y borrar tareas.
- **Pantalla de Categorías**: Crear categorías de tareas.
- **Pantalla de Calendario**: Ver los rangos de fechas de cada tarea.
- **Pantalla de Admin**: El creador de la familia puede añadir nuevos miembros y eliminarlos. Los usuarios pueden unirse a una familia o crear una nueva. Si el admin le pasa un código, el usuario se une a la familia como lector hasta que se le cambie el rol.

## Funcionalidades
- Solo el **admin** puede dar de alta usuarios y crear familias.
- Tipos de usuarios:
  - **Admin**: Puede realizar todas las acciones (crear, editar, borrar tareas, asignar tareas, gestionar usuarios y crear familias).
  - **Editor**: Puede hacer todo lo que los lectores, además de crear, editar y borrar tareas, asignar tareas, y gestionar categorías.
  - **Lector**: Solo puede ver las tareas asignadas a él o comunes a la familia.

## Entidades del Sistema

### Tarea
- **Fecha Comienzo**
- **Fecha Fin**
- **Nombre** (obligatorio)
- **Descripción** (obligatorio)
- **Persona Asignada**: Por defecto, no se asignan a nadie.
  - Se pueden asignar a una lista de personas.
  - Asignar a la familia implica asignar la tarea a todos los miembros.
- **Categoría**: Por defecto, habrá una categoría genérica.

### Categoría
- **Nombre**
- **Abreviatura**
- **Color**

### Usuario
- **Nombre**
- **Email**
- **Clave**
- **Icono**
- **Rol**

### Rol
- **Admin**
- **Editor**
- **Lector**
