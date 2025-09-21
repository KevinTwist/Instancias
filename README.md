Docente: Muñoz Lautaro Gabriel
Fecha: 16/09/2025
Ejercicio integral:

Se requiere de un desarrollo que nos ayude a administrar nuestras instancias de computadores virtuales en la nube.
Se requiere almacenar la siguiente información:
Nombre.
•	Versión.
•	Sistema operativo.
•	Estado.
Las instancias se deben de poder levantar (cambiar el estado a 1 o “up”) y bajar (estado en 0 o “down).
Dichas instancias pueden tener múltiples finalidades, pero para facilitar su manejo, vamos a clasificarlas en:
•	De proceso de datos.
•	De Aplicación.
Las de proceso son instancias que nos permitirán realizar procesos, por ejemplo, clonar bases de datos, filtrarlas y almacenarlas dentro de otra por lo que queremos almacenar:
Datos de origen.
Datos de fin.
Al momento de “levantar” la instancia debe confirmar que posee acceso correcto a datos de origen y fin (para comprobar que el proceso se realizará correctamente) por lo que al levantarse debería cambiar de estado a 1 o “up” y mostrar en pantalla que se ha levantado correctamente la instancia, y que posee acceso a “datos de origen almacenados” y a “datos de fin almacenados”.

Las de aplicación son instancias que nos permitirán ser la base para las aplicaciones que los desarrolladores deseen implementar o publicar en nuestra nube por lo que debe almacenarse:
lenguaje de programación:
Versión del lenguaje:
Base de datos: (url o ubicación de la base de datos).
Al momento de “levantar” la instancia debe confirmar que se ha instalado el lenguaje de programación en la versión deseada y que se posee acceso correcto a la base de datos, por lo que al levantarse debería cambiar de estado a 1 o “up” y mostrar en pantalla que se ha levantado correctamente la instancia, que se instaló el lenguaje (lenguaje de programación almacenado) en la versión (versión almacenada) y que posee acceso a la base de datos (base de datos almacenada”.


Se necesita instanciar al menos dos maquinar virtuales de cada tipo dentro de un arreglo de maquinas virtuales para poder levantarlas y bajarlas en simultaneo, y que cada clase realice el proceso almacenado independientemente.


