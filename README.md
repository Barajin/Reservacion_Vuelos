# KatyProject

## Reservación de vuelos 

Este sistema permitirá la venta de boletos de una linea aérea. También es importante agregar la opción de pasajeros frecuentes que acomularán millas. Se manejara información para ciudades a las que vuela la aerolinea, vuelos que ofrece, datos para usuarios de club premier y boletos vendidos.

Opciones a incluir:
- <strong>Alta de ciudades:</strong> que serán destinos u origenes para viajar. Los datos a incluir son: Clave de la ciudad, Nombre de la ciudad, Estado. Utiliza un arreglo de objetos para que guardes la información de las ciudades.

- <strong>Alta de vuelos:</strong> Aqui se permitirá agregar los datos de los vuelos: número de pasajeros, origen, y destino(tomado de las ciudades tanto en origen como destino), capacidad, boletos vendidos, costo, millas, dias en que se realiza el vuelo(diaria, lunes, martes, etc..). Utiliza una clase vuelo para agregar objetos a un ArrayList.

- <strong>Alta club premier:</strong> se darán de alta los pasajeros que cuenten con club premier para que acumulen millas en cada vuelo que compren, los datos que se deben de considerar son: clave del club premier, Nombre, Domicilio, Millas acomuladas. Se debe de crear una clase, llamada ClubPremier para que se agregen los objetos a una TablaHash.

- <strong>Compra de boletos:</strong> Se utilizará para vende boletos de los vuelos dados de alta, seleccionar el origen, destino y siempre y cuando se tenga disponibilidad. Hay que considerar Clave del Boleto, Nombre del pasajero, Edad del pasajero, Clave del vuelo(tomado del catálogo de vuelos), Clave del club premier(si es que se tiene). Al realizar una compra se debe de considerar actualizar la información de los datos de Boletos vendidos(para el vuelo seleccionado, en el ArrayList de vuelos) y también se deben de acumular las millas en caso de que el pasajero esté dado de alta en el club premier de la TablaHash de los clientes que tienen Club Premier.

- <strong>Consulta de vuelos disponibles:</strong> Aquí aparecerán todos los vuelos para una ciudad que se proporcione, siempre y cuando el vuelo tenga disponibilidad.

 <strong>1er. Avance Proyecto Integrador: Diseño conceptual y lógico </strong>
Con las necesidades de información de la empresa diseñe:

  - El diagrama E-R ( a mano, digitalizado)
  - El diagrama E-R ( en Word o herramienta)
  - El esquema para MySQL o SQLServer (el script que cree las tablas).
  - Un script que llene las tablas con datos muestra:
      Los catálogos  deben tener al menos 10 filas 
      Al menos 100 filas en las tablas de operación
