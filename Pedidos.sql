CREATE DATABASE Pedidos


CREATE TABLE CLIENTE (
IDCLIENTE INT IDENTITY (1,1) NOT NULL,
NOMBRE NVARCHAR (50) NOT NULL,
APELLIDO NVARCHAR (50) NOT NULL,
TELEFONO NVARCHAR (50) NULL,
CORREOELECTRONICO NVARCHAR (255) NULL,
DIRECCION NVARCHAR (50) NOT NULL,
PRIMARY KEY (IDCLIENTE),
);
CREATE TABLE PEDIDO (
IDPEDIDO INT IDENTITY (1,1) NOT NULL,
IDCLIENTE INT NOT NULL,
FECHA DATETIME NOT NULL,
TOTAL MONEY NOT NULL,
ESTADO NVARCHAR (20) NOT NULL,
PRIMARY KEY (IDPEDIDO),
FOREIGN KEY (IDCLIENTE) REFERENCES CLIENTE (IDCLIENTE)
);

INSERT INTO CLIENTE VALUES ('Rocio', 'Fernandez', '+59172979377', 'pedro@gmail.com', 'Senac');
INSERT INTO CLIENTE VALUES ('Jorge', 'P�rez', '+59161234567', 'adrian@gmail.com', 'Juan XXIII');
INSERT INTO CLIENTE VALUES ('Bel�n', 'Gonz�lez', '+59173456789', 'belen@gmail.com', 'Una tercera direcci�n');
INSERT INTO CLIENTE VALUES ('Ana', 'Rodr�guez', '+59169876543', 'ana@gmail.com', 'Una cuarta direcci�n');
INSERT INTO CLIENTE VALUES ('Elena', 'Mart�nez', '+59166554433', 'elena@gmail.com', 'Avenida Principal');
INSERT INTO CLIENTE VALUES ('Mario', 'L�pez', '+59177788899', 'mario@gmail.com', 'Centro');
INSERT INTO CLIENTE VALUES ('Laura', 'Garc�a', '+59199988877', 'laura@gmail.com', 'Calle Secundaria 789');
INSERT INTO CLIENTE VALUES ('Roberto', 'S�nchez', '+59133344455', 'roberto@gmail.com', 'Calle Principal 101');
INSERT INTO CLIENTE VALUES ('Sara', 'Hern�ndez', '+59166655544', 'sara@gmail.com', 'Avenida Central 222');
INSERT INTO CLIENTE VALUES ('Gabriela', 'Mallcu', '+59166655548', 'Gabi@gmail.com', 'Juan XXIII');

INSERT INTO PEDIDO VALUES (5, '2024-03-19 11:00:00', 80.00, 'Pendiente');
INSERT INTO PEDIDO VALUES (6, '2024-03-20 13:20:00', 90.00, 'En proceso');
INSERT INTO PEDIDO VALUES (7, '2024-03-21 10:45:00', 110.00, 'Completado');
INSERT INTO PEDIDO VALUES (8, '2024-03-22 14:15:00', 130.00, 'Pendiente');
INSERT INTO PEDIDO VALUES (9, '2024-03-23 12:30:00', 70.00, 'En proceso');
INSERT INTO PEDIDO VALUES (10, '2024-03-24 15:40:00', 95.00, 'Completado');
INSERT INTO PEDIDO VALUES (11, '2024-03-25 09:10:00', 115.00, 'Pendiente');
INSERT INTO PEDIDO VALUES (12, '2024-03-26 11:50:00', 140.00, 'En proceso');
INSERT INTO PEDIDO VALUES (13, '2024-03-27 14:00:00', 75.00, 'Completado');
INSERT INTO PEDIDO VALUES (5, '2024-03-28 16:20:00', 100.00, 'Pendiente');
INSERT INTO PEDIDO VALUES (6, '2024-03-29 09:30:00', 85.00, 'Pendiente');
INSERT INTO PEDIDO VALUES (7, '2024-03-30 11:45:00', 95.00, 'En proceso');
INSERT INTO PEDIDO VALUES (8, '2024-03-31 10:20:00', 110.00, 'Completado');
INSERT INTO PEDIDO VALUES (9, '2024-04-01 13:15:00', 120.00, 'Pendiente');
INSERT INTO PEDIDO VALUES (10, '2024-04-02 14:50:00', 130.00, 'En proceso');
INSERT INTO PEDIDO VALUES (11, '2024-04-03 12:10:00', 140.00, 'Completado');
INSERT INTO PEDIDO VALUES (12, '2024-04-04 15:25:00', 150.00, 'Pendiente');
INSERT INTO PEDIDO VALUES (13, '2024-04-05 16:40:00', 160.00, 'En proceso');
INSERT INTO PEDIDO VALUES (5, '2024-04-06 09:00:00', 170.00, 'Completado');
INSERT INTO PEDIDO VALUES (6, '2024-04-07 10:35:00', 180.00, 'Pendiente');
INSERT INTO PEDIDO VALUES (7, '2024-04-08 11:55:00', 190.00, 'En proceso');
INSERT INTO PEDIDO VALUES (8, '2024-04-09 13:20:00', 200.00, 'Completado');
INSERT INTO PEDIDO VALUES (9, '2024-04-10 14:45:00', 210.00, 'Pendiente');
INSERT INTO PEDIDO VALUES (10, '2024-04-11 15:55:00', 220.00, 'En proceso');
INSERT INTO PEDIDO VALUES (11, '2024-04-12 16:25:00', 230.00, 'Completado');