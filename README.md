# Proyecto-.Net
Aplicación escritorio:
La aplicación permitirá administrar los pedidos que serán capturados telefónicamente o por mostrador. El pedido contará con estado (recibido, cocina, enviado, entregado, cancelado), detalle del pedido (código de producto, su descripción, cantidad por productos, precios unitario), total $ a cobrar, indicador si retira en mostrador ó envío a domicilio, permitir el ingreso sobre cuánto abonará el cliente para calcular el cambio, el ingreso de los datos de cliente con posibilidad a registrarlo bajo un cliente nn si no se requiere registrar (Ej: caso de compra única por mostrador).
Ingresando el teléfono podría localizarse el cliente si a tuvo pedidos previamente (o sea si es cliente).

Dashboard/Semáforo de estado de pedidos: resumen numérico de cantidad de pedidos del día agrupados por estado de los mismos.

Los productos disponibles en la carga de los pedidos podrán administrarse (CRUD) y éstos dispondrán de código, descripción, precio unitario, si está publicado en el catálogo web.

La aplicación permitirá la administración de clientes los cuales dispondrán de domicilio, teléfono y nombre (auto cargados en la generación de un pedido de ser primer pedido). 

Existirá una ventana de Caja la cual permitirá iniciar la “Caja” con un monto $ a ingresar y se registrará la fecha y hora en que se realizó. Existirá la posibilidad de calcularse la diferencia de éste monto en base a los pedidos entregados a partir de la fecha de apertura de caja. Existirá la posibilidad de cerrar la caja la cual arrojará el reporte de los montos calculados y reinicializar el estado de la caja para su próxima reapertura.

La aplicación dispondrá un menú para personalizar contenido parcial de la plataforma web (nombre comercial, domicilio, teléfono de contacto, horario de atención)

Reportes:
productos más vendidos y menos vendidos en períodos predefinidos.
tiempo min/avg/max entre estados por período en períodos predefinidos.
totales de ventas por día en períodos predefinidos.
horarios de más ventas por totales $ y por productos específicos
horarios del día que se realizan delivery y cantidad de envío en períodos predefinidos.
clientes que más compraron en $ en períodos predefinidos
clientes que hace más tiempo que no compran. campaña de fidelización
*”en períodos predefinidos”: día actual, última semana, último mes. El período podría diferir entre reporte y reporte si es conveniente para el sistema o propósito del reporte.

Aplicación Web:
representación de catálogo de productos en estado publicado con su precio unitario, nombre de pizzería, teléfono y domicilio, y horario de contacto. Esta información es configurable desde la app de escritorio
