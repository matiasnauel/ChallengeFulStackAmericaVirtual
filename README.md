# Challenge America Virtual

El proyecto es una aplicación full stack en asp.net core mvc el cual tiene como proposito mostrar el clima en base a la ubicación del pais y la ciudad.

## Comenzando 🚀

_Estas instrucciones te permitirán obtener una copia del proyecto en funcionamiento en tu máquina local para propósitos de desarrollo y pruebas._

Mira **Deployment** para conocer como desplegar el proyecto.


### Pre-requisitos 📋

_Que cosas necesitas para instalar el software y como instalarlas_
En primer lugar se debe importar la base de datos ScriptChallengeDevelopment el cual tiene almacenado un usuario y su password para dicha prueba.
El usuario es: AmericanVirtual@gmail.com
Y su contraseña: 12345678
Una vez instala la base de datos, se debe abrir el programa y modificar el archivo appsettings.json el cual tiene la conexión a la base de datos.
Se debe modificar nombre de la base de datos local el cual se indica como "DataSource=Database" 
A partir de esto se debe verificar que las dependencias de EntityFramework esten instaladas, en el caso que no se deben instalar  la version (6.4.4) con el cual
esta hecho el trabajo. 



### Instalación 🔧
_Hay que tener en cuenta un dato importante. Se utiliza una api externa para obtener la información meteorologica. Esta api es extraida de esta pagina : https://openweathermap.org/
Si por alguna razon la api que esta utilizando el proyecto no funciona, se debe a que por cuestiones de autenticación el token no funciona. En este caso se debera registrar en
la pagina el cual se mostro anteriormente, y en la sección del perfil habra un apartado llamado My API Keys donde se les otorgara su api token privado. Este debera ser reemplazado
en la linea 138 y 170 el cual tiene el siguiente formato : app.url = `https://api.openweathermap.org/data/2.5/forecast?q=Buenos Aires&&cnt=5&lang=es&appid=b329122e8d5dbbeefad2af30cc4e43d6`
luego de &appid="Tutoke".

_Una vez realizado dicha verificación de la base de datos y de los paquetes que utiliza el proyecto, se puede realizar la ejecución del mismo.


_Finaliza con un ejemplo de cómo obtener datos del sistema o como usarlos para una pequeña demo_

_https://s2.gifyu.com/images/2021-01-21-23-02-48.gif en este gif se puede apreciar como es el funcionamiento de la app.

### Y las pruebas de estilo de codificación ⌨️
_Se utilizo asp.net core mvc y entity framework para el mapeo de datos. En la parte del front-end se utilizo html,css, js y jquery para los estilos y las peticiones al servidor.
Ademas se utilizo twiter-bootstrap para los estilos de la pagina.

_Agrega notas adicionales sobre como hacer deploy_

## Construido con 🛠️

_Las herramientas que utilize para el proyecto_

* [ApiWeatherForecast](https://openweathermap.org/forecast5)- Api utilizada el cual trae la información del clima por 5 dias cada 3 horas.
* [sweetAlert2](https://sweetalert2.github.io/) - Libreria utilizada para el manejor de excepciones. 
* [ionicons](https://unpkg.com/ionicons@5.2.3/dist/ionicons.js) - Usado para los iconos del tiempo.
* [RestCountries](https://restcountries.eu/) - Api utilizada para obtener los paises y sus ciudades.


## Autores ✒️

* **Matias Ayala** - *Trabajo Inicial* - (https://www.linkedin.com/in/matias-ayala-85b22a199/)
* **Matias Ayala** - *Documentación* - (https://www.linkedin.com/in/matias-ayala-85b22a199/)






---
