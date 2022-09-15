# DPRN3_U2_EA_JHRM
Programa para dar de alta información de clientes en una sola tabla de BD local mediante interfaz gráfica de usuario

## Interfaz gráfica
Consta de una sola ventana con campos y 2 botones

<p align="center">
  <img src="https://user-images.githubusercontent.com/38293508/190519950-fe78b0bd-b553-4043-b004-6330d07f3ada.png"/>
</p>



El botón conectar permite hacer una prueba de conexión con la base de datos locales antes de intentar cualquier registro

## Base de datos
La conexión con la base de datos local está configurada con SQL Server. Si requiere otro manejador, se debe reconfigurar de acuerdo a dicho manejador. 
Para que los registros se carguen exitosamente, hay que crear la tabla de acuerdo al siguiente esquema.

<p align="center">
  <img src="https://user-images.githubusercontent.com/38293508/190520568-702dd081-5183-4db8-be59-cbe2019e5b9c.png"/>
</p>

## Versiones y dependencias
* System.Data.SqlClient
* Visual Studio Community 2019 16.11.19
