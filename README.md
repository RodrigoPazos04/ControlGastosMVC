# Control de Gastos - ASP.NET Core MVC

Aplicación web desarrollada con ASP.NET Core MVC que permite gestionar gastos personales de forma simple y organizada.

## Funcionalidades

- Crear gastos
- Ver lista de gastos
- Editar gastos
- Eliminar gastos
- Filtrar por categoría
- Calcular total de gastos automáticamente

## Tecnologías utilizadas

- ASP.NET Core MVC
- Entity Framework Core
- SQL Server (LocalDB)
- Bootstrap

## Descripción

La aplicación permite registrar gastos indicando descripción, monto y categoría.  
Además, incluye funcionalidades de filtrado por categoría y cálculo dinámico del total, mejorando la experiencia del usuario y el análisis de datos.

## Estructura del proyecto

- Models → Definición de entidades (Gasto)
- Controllers → Lógica de negocio (GastosController)
- Views → Interfaz de usuario

## Cómo ejecutar

1. Clonar el repositorio  
2. Abrir el proyecto en Visual Studio  
3. Ejecutar migraciones:  
   - Add-Migration Inicial  
   - Update-Database  
4. Ejecutar el proyecto (F5)  

## Autor

Rodrigo Pazos
