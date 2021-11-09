use [BugTrackerTP]

/** Perfiles **/
SET IDENTITY_INSERT Perfiles ON 
INSERT INTO Perfiles (id_perfil, nombre, borrado) VALUES (1, 'Administrador', 0)
INSERT INTO Perfiles (id_perfil, nombre, borrado) VALUES (2, 'Tester', 0)
INSERT INTO Perfiles (id_perfil, nombre, borrado) VALUES (3, 'Desarrollador', 0)
INSERT INTO Perfiles (id_perfil, nombre, borrado) VALUES (4, 'Responsable de Reportes', 0)
SET IDENTITY_INSERT Perfiles OFF

/** Usuarios **/
SET IDENTITY_INSERT Usuarios ON 
INSERT INTO Usuarios (id_usuario, id_perfil, usuario, password, email, estado, borrado) VALUES (1, 1, 'administrador', '12345', 'admin@gmail.com', 'S', 0)
INSERT INTO Usuarios (id_usuario, id_perfil, usuario, password, email, estado, borrado) VALUES (2, 2, 'Tester Ariel', '12345', 'ariel@gmail.com', 'N', 0)
INSERT INTO Usuarios (id_usuario, id_perfil, usuario, password, email, estado, borrado) VALUES (4, 3, 'Tester Miguel', '12345', 'miguel@gmail.com', 'S', 0)
INSERT INTO Usuarios (id_usuario, id_perfil, usuario, password, email, estado, borrado) VALUES (5, 2, 'Tester Ana', '12345', 'ana@gmail.com', 'N', 0)
INSERT INTO Usuarios (id_usuario, id_perfil, usuario, password, email, estado, borrado) VALUES (6, 3, 'Tester Diego', '12345', 'diego@gmail.com', 'N', 0)
INSERT INTO Usuarios (id_usuario, id_perfil, usuario, password, email, estado, borrado) VALUES (7, 4, 'Tester Micaela', '12345', 'mica@gmail.com', 'S', 0)
INSERT INTO Usuarios (id_usuario, id_perfil, usuario, password, email, estado, borrado) VALUES (8, 1, 'a', 'a', 'a@a.com', 'S', 0)
SET IDENTITY_INSERT Usuarios OFF

/** Productos **/
SET IDENTITY_INSERT Productos ON 
INSERT INTO Productos (id_producto, nombre, borrado) VALUES (1, 'Software de Gestión', 0)
INSERT INTO Productos (id_producto, nombre, borrado) VALUES (2, 'Soft. de Gestión de Identidad', 0)
INSERT INTO Productos (id_producto, nombre, borrado) VALUES (3, 'Software de Auditoría', 0)
INSERT INTO Productos (id_producto, nombre, borrado) VALUES (4, 'Soft. Vulnerabilidades', 0)
SET IDENTITY_INSERT Productos OFF

/** Contactos **/
SET IDENTITY_INSERT Contactos ON
insert into Contactos (id_contacto, nombre, apellido, email, telefono, borrado) values (1, 'Reeta', 'Cassely', 'rcassely0@msu.edu', '8786179331', 0);
insert into Contactos (id_contacto, nombre, apellido, email, telefono, borrado) values (2, 'Harp', 'McShane', 'hmcshane1@guardian.co.uk', '7585384546', 0);
insert into Contactos (id_contacto, nombre, apellido, email, telefono, borrado) values (3, 'Ade', 'Hagger', 'ahagger2@alexa.com', '4676023521', 0);
insert into Contactos (id_contacto, nombre, apellido, email, telefono, borrado) values (4, 'Danyelle', 'Zanassi', 'dzanassi3@noaa.gov', '3462399871', 0);
insert into Contactos (id_contacto, nombre, apellido, email, telefono, borrado) values (5, 'Tedd', 'Soggee', 'tsoggee4@dagondesign.com', '1948772623', 0);
insert into Contactos (id_contacto, nombre, apellido, email, telefono, borrado) values (6, 'Sunshine', 'Jachimiak', 'sjachimiak5@pcworld.com', '3624233470', 0);
insert into Contactos (id_contacto, nombre, apellido, email, telefono, borrado) values (7, 'Royal', 'Niche', 'rniche6@state.tx.us', '8351159088', 0);
insert into Contactos (id_contacto, nombre, apellido, email, telefono, borrado) values (8, 'Becky', 'Wilby', 'bwilby7@etsy.com', '1999917942', 0);
insert into Contactos (id_contacto, nombre, apellido, email, telefono, borrado) values (9, 'Pieter', 'Legister', 'plegister8@miitbeian.gov.cn', '3399205908', 0);
insert into Contactos (id_contacto, nombre, apellido, email, telefono, borrado) values (10, 'Gage', 'Chalkly', 'gchalkly9@nyu.edu', '5363437076', 0);
insert into Contactos (id_contacto, nombre, apellido, email, telefono, borrado) values (11, 'Sander', 'Ellissen', 'sellissena@princeton.edu', '9784609874', 0);
insert into Contactos (id_contacto, nombre, apellido, email, telefono, borrado) values (12, 'Berna', 'Pesticcio', 'bpesticciob@parallels.com', '4798499229', 0);
insert into Contactos (id_contacto, nombre, apellido, email, telefono, borrado) values (13, 'Caty', 'Sebert', 'csebertc@google.com.au', '5583351952', 0);
insert into Contactos (id_contacto, nombre, apellido, email, telefono, borrado) values (14, 'Roana', 'Roblett', 'rroblettd@oracle.com', '8183478636', 0);
insert into Contactos (id_contacto, nombre, apellido, email, telefono, borrado) values (15, 'Jerome', 'Decreuze', 'jdecreuzee@ca.gov', '3681198942', 0);
insert into Contactos (id_contacto, nombre, apellido, email, telefono, borrado) values (16, 'Dev', 'Grene', 'dgrenef@flavors.me', '7545326095', 0);
insert into Contactos (id_contacto, nombre, apellido, email, telefono, borrado) values (17, 'Reube', 'Chessun', 'rchessung@reuters.com', '1353478116', 0);
insert into Contactos (id_contacto, nombre, apellido, email, telefono, borrado) values (18, 'Lacee', 'Rushman', 'lrushmanh@vimeo.com', '5412675057', 0);
insert into Contactos (id_contacto, nombre, apellido, email, telefono, borrado) values (19, 'Seana', 'Sabathe', 'ssabathei@webeden.co.uk', '8029780669', 0);
insert into Contactos (id_contacto, nombre, apellido, email, telefono, borrado) values (20, 'Ivor', 'Vereker', 'iverekerj@abc.net.au', '6274749332', 0);
SET IDENTITY_INSERT Contactos OFF

/** Barrios **/
SET IDENTITY_INSERT Barrios ON
INSERT INTO Barrios (id_barrio, nombre, borrado) VALUES (1, 'Alta Córdoba', 0)
INSERT INTO Barrios (id_barrio, nombre, borrado) VALUES (2, 'Alberdi', 0)
INSERT INTO Barrios (id_barrio, nombre, borrado) VALUES (3, 'Güemes', 0)
INSERT INTO Barrios (id_barrio, nombre, borrado) VALUES (4, 'Cofico', 0)
INSERT INTO Barrios (id_barrio, nombre, borrado) VALUES (5, 'Cerro', 0)
SET IDENTITY_INSERT Barrios OFF

/** Proyectos **/
SET IDENTITY_INSERT Proyectos ON
INSERT INTO Proyectos (id_proyecto, id_producto, descripcion, alcance, version, id_responsable, borrado) VALUES (1, 2, 'testDesc', 'testAlc', '0.0.0', 4, 0)
INSERT INTO Proyectos (id_proyecto, id_producto, descripcion, alcance, version, id_responsable, borrado) VALUES (2, 4, 'Probar vulnerabilidades', 'Sin definir', '0.0.1', 6, 0)
SET IDENTITY_INSERT Proyectos OFF
