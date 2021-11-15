/** REVISAR QUE NO HAYA FACTURAS EXISTENTES ANTES 
	La idea es crear esto con las facturas vacias porque estan ordenadas por orden cronologico
	Si hay facturas existentes el orden de numero y fecha va a quedar mal
	y nose si va a saltar error por crear facturas ya hechas**/

use BugTrackerTP

insert into Facturas (numero_factura, id_cliente, fecha, id_usuario_creador) values (1, 1, '2020-10-04 04:16:13', 1);
insert into FacturasDetalle (numero_factura, numero_orden_detalle, id_producto, id_proyecto, precio) values (1, 1, 4, null, 696.38);

insert into Facturas (numero_factura, id_cliente, fecha, id_usuario_creador) values (2, 1, '2020-11-01 05:45:01', 4);
insert into FacturasDetalle (numero_factura, numero_orden_detalle, id_producto, id_proyecto, precio) values (2, 1, null, 1, 544.65);
insert into FacturasDetalle (numero_factura, numero_orden_detalle, id_producto, id_proyecto, precio) values (2, 2, 4, null, 837.45);

insert into Facturas (numero_factura, id_cliente, fecha, id_usuario_creador) values (3, 2, '2020-11-12 06:11:46', 1);
insert into FacturasDetalle (numero_factura, numero_orden_detalle, id_producto, id_proyecto, precio) values (3, 1, 3, null, 521.35);

insert into Facturas (numero_factura, id_cliente, fecha, id_usuario_creador) values (4, 2, '2020-12-19 02:58:11', 7);
insert into FacturasDetalle (numero_factura, numero_orden_detalle, id_producto, id_proyecto, precio) values (4, 1, null, 2, 641.47);

insert into Facturas (numero_factura, id_cliente, fecha, id_usuario_creador) values (5, 1, '2020-12-30 10:40:30', 6);
insert into FacturasDetalle (numero_factura, numero_orden_detalle, id_producto, id_proyecto, precio) values (5, 1, 4, null, 854.26);
insert into FacturasDetalle (numero_factura, numero_orden_detalle, id_producto, id_proyecto, precio) values (5, 2, null, 2, 958.43);

insert into Facturas (numero_factura, id_cliente, fecha, id_usuario_creador) values (6, 1, '2021-01-11 17:32:34', 6);
insert into FacturasDetalle (numero_factura, numero_orden_detalle, id_producto, id_proyecto, precio) values (6, 1, 3, null, 990.74);

insert into Facturas (numero_factura, id_cliente, fecha, id_usuario_creador) values (7, 1, '2021-02-06 19:27:36', 2);
insert into FacturasDetalle (numero_factura, numero_orden_detalle, id_producto, id_proyecto, precio) values (7, 1, 4, null, 888.16);
insert into FacturasDetalle (numero_factura, numero_orden_detalle, id_producto, id_proyecto, precio) values (7, 2, 2, null, 784.42);
insert into FacturasDetalle (numero_factura, numero_orden_detalle, id_producto, id_proyecto, precio) values (7, 3, null, 1, 669.35);

insert into Facturas (numero_factura, id_cliente, fecha, id_usuario_creador) values (8, 2, '2021-03-07 23:41:15', 2);
insert into FacturasDetalle (numero_factura, numero_orden_detalle, id_producto, id_proyecto, precio) values (8, 1, 2, null, 678.73);
insert into FacturasDetalle (numero_factura, numero_orden_detalle, id_producto, id_proyecto, precio) values (8, 2, null, 2, 427.66);

insert into Facturas (numero_factura, id_cliente, fecha, id_usuario_creador) values (9, 1, '2021-03-22 04:05:36', 7);
insert into FacturasDetalle (numero_factura, numero_orden_detalle, id_producto, id_proyecto, precio) values (9, 1, 1, null, 117.99);

insert into Facturas (numero_factura, id_cliente, fecha, id_usuario_creador) values (10, 2, '2021-04-15 21:06:28', 1);
insert into FacturasDetalle (numero_factura, numero_orden_detalle, id_producto, id_proyecto, precio) values (10, 1, null, 2, 800.95);

insert into Facturas (numero_factura, id_cliente, fecha, id_usuario_creador) values (11, 1, '2021-04-23 10:45:18', 2);
insert into FacturasDetalle (numero_factura, numero_orden_detalle, id_producto, id_proyecto, precio) values (11, 1, null, 2, 790.34);
insert into FacturasDetalle (numero_factura, numero_orden_detalle, id_producto, id_proyecto, precio) values (11, 2, 3, null, 693.89);

insert into Facturas (numero_factura, id_cliente, fecha, id_usuario_creador) values (12, 2, '2021-04-26 19:35:35', 1);
insert into FacturasDetalle (numero_factura, numero_orden_detalle, id_producto, id_proyecto, precio) values (12, 1, null, 1, 328.22);
insert into FacturasDetalle (numero_factura, numero_orden_detalle, id_producto, id_proyecto, precio) values (12, 2, 1, null, 331.68);

insert into Facturas (numero_factura, id_cliente, fecha, id_usuario_creador) values (13, 3, '2021-05-10 19:33:47', 5);
insert into FacturasDetalle (numero_factura, numero_orden_detalle, id_producto, id_proyecto, precio) values (13, 1, 2, null, 775.64);
insert into FacturasDetalle (numero_factura, numero_orden_detalle, id_producto, id_proyecto, precio) values (13, 2, null, 2, 278.65);

insert into Facturas (numero_factura, id_cliente, fecha, id_usuario_creador) values (14, 1, '2021-05-29 08:45:21', 1);
insert into FacturasDetalle (numero_factura, numero_orden_detalle, id_producto, id_proyecto, precio) values (14, 1, 4, null, 928.32);

insert into Facturas (numero_factura, id_cliente, fecha, id_usuario_creador) values (15, 2, '2021-06-10 17:56:39', 8);
insert into FacturasDetalle (numero_factura, numero_orden_detalle, id_producto, id_proyecto, precio) values (15, 1, null, 1, 109.3);
insert into FacturasDetalle (numero_factura, numero_orden_detalle, id_producto, id_proyecto, precio) values (15, 2, 3, null, 828.9);

insert into Facturas (numero_factura, id_cliente, fecha, id_usuario_creador) values (16, 3, '2021-06-24 13:14:28', 4);
insert into FacturasDetalle (numero_factura, numero_orden_detalle, id_producto, id_proyecto, precio) values (16, 1, null, 2, 954.21);

insert into Facturas (numero_factura, id_cliente, fecha, id_usuario_creador) values (17, 3, '2021-07-06 08:44:44', 6);
insert into FacturasDetalle (numero_factura, numero_orden_detalle, id_producto, id_proyecto, precio) values (17, 1, null, 2, 422.73);
insert into FacturasDetalle (numero_factura, numero_orden_detalle, id_producto, id_proyecto, precio) values (17, 2, 1, null, 506.26);

insert into Facturas (numero_factura, id_cliente, fecha, id_usuario_creador) values (18, 2, '2021-07-15 23:32:08', 8);
insert into FacturasDetalle (numero_factura, numero_orden_detalle, id_producto, id_proyecto, precio) values (18, 1, null, 2, 291.28);
insert into FacturasDetalle (numero_factura, numero_orden_detalle, id_producto, id_proyecto, precio) values (18, 2, 1, null, 623.03);

insert into Facturas (numero_factura, id_cliente, fecha, id_usuario_creador) values (19, 1, '2021-07-26 08:51:33', 7);
insert into FacturasDetalle (numero_factura, numero_orden_detalle, id_producto, id_proyecto, precio) values (19, 1, 3, null, 788.89);

insert into Facturas (numero_factura, id_cliente, fecha, id_usuario_creador) values (20, 1, '2021-08-05 16:43:13', 4);
insert into FacturasDetalle (numero_factura, numero_orden_detalle, id_producto, id_proyecto, precio) values (20, 1, 2, null, 417.51);
insert into FacturasDetalle (numero_factura, numero_orden_detalle, id_producto, id_proyecto, precio) values (20, 2, null, 2, 234.0);

insert into Facturas (numero_factura, id_cliente, fecha, id_usuario_creador) values (21, 2, '2021-09-04 18:15:41', 9);
insert into FacturasDetalle (numero_factura, numero_orden_detalle, id_producto, id_proyecto, precio) values (21, 1, 4, null, 750.36);
insert into FacturasDetalle (numero_factura, numero_orden_detalle, id_producto, id_proyecto, precio) values (21, 2, 2, null, 605.5);

insert into Facturas (numero_factura, id_cliente, fecha, id_usuario_creador) values (22, 3, '2021-09-15 16:39:55', 4);
insert into FacturasDetalle (numero_factura, numero_orden_detalle, id_producto, id_proyecto, precio) values (22, 1, 2, null, 485.13);
insert into FacturasDetalle (numero_factura, numero_orden_detalle, id_producto, id_proyecto, precio) values (22, 2, null, 1, 109.57);

insert into Facturas (numero_factura, id_cliente, fecha, id_usuario_creador) values (23, 1, '2021-09-17 18:54:05', 2);
insert into FacturasDetalle (numero_factura, numero_orden_detalle, id_producto, id_proyecto, precio) values (23, 1, null, 2, 545.44);

insert into Facturas (numero_factura, id_cliente, fecha, id_usuario_creador) values (24, 1, '2021-09-24 21:26:23', 2);
insert into FacturasDetalle (numero_factura, numero_orden_detalle, id_producto, id_proyecto, precio) values (24, 1, 3, null, 745.84);
insert into FacturasDetalle (numero_factura, numero_orden_detalle, id_producto, id_proyecto, precio) values (24, 2, null, 2, 435.64);

insert into Facturas (numero_factura, id_cliente, fecha, id_usuario_creador) values (25, 3, '2021-10-06 04:07:04', 5);
insert into FacturasDetalle (numero_factura, numero_orden_detalle, id_producto, id_proyecto, precio) values (25, 1, 1, null, 896.02);
insert into FacturasDetalle (numero_factura, numero_orden_detalle, id_producto, id_proyecto, precio) values (25, 2, null, 1, 339.16);
insert into FacturasDetalle (numero_factura, numero_orden_detalle, id_producto, id_proyecto, precio) values (25, 3, 2, null, 236.71);