create database OrdenesTrabajo

use OrdenesTrabajo

create table Orden
(id_orden numeric(10,0) identity primary key not null,
fecha_ingreso date not null,
observacionesrecibido varchar(200) null,
diagnostico varchar(200) not null,
fecha_salida date null,
observacionesfinal varchar (200) null)

create table Cliente
(id_cliente numeric(10,0) identity primary key not null,
nombre varchar(50) not null,
telefono varchar(10) not null,
direccion varchar(100) null,
correo varchar(50) not null,
ci numeric(10,0) not null)

create table Orden_Seguimiento
(id_seguimiento numeric(10,0) identity primary key not null,
descripcion varchar(200) null,
fecharevision date null)

create table Estado_Orden
(estado_orden varchar(20) primary key not null)

create table Equipo
(id_equipo numeric(10,0) identity primary key not null,
tipo varchar (20) not null,
modelo varchar (25) not null,
serie_equipo numeric (10,0) not null,
discoduro varchar (30) null,
estadoHDD varchar (20) null,
serialRAM1 numeric (10,0) null,
serialRAM2 numeric (10,0) null,
serialCargador numeric (10,0) null,
serialBateria numeric (10,0),
observaciones varchar(200) null,
estadoequipo varchar (20) null)

create table Usuario
(id_usuario numeric(10,0) identity primary key not null,
nombre_usuario varchar (50) not null,
contrasena varchar (30) not null,
rol numeric(3,0) not null)

create table Prioridad
(desc_prioridad varchar (20) primary key not null)


alter table Orden
add nombre_us varchar(50) not null
alter table Orden
add foreign key (nombre_us) references Usuario(nombre_usuario)
go

alter table Orden
add prioridad_or varchar(20) not null
alter table Orden
add foreign key (prioridad_or) references Prioridad(desc_prioridad)
go

alter table Orden
add estado_order varchar(20) not null
alter table Orden
add foreign key (estado_order) references Estado_orden(estado_orden)
go

alter table Orden
add id_estado_FK numeric(10,0) not null

alter table Orden
add foreign key (id_estado_FK) references Estado_Orden(id_estado)
go

alter table Equipo
add id_orden_FK numeric(10,0) not null
alter table Equipo
add foreign key (id_orden_FK) references Orden(id_orden)
go

alter table Orden_Seguimiento
add id_orden_FK numeric(10,0) not null
alter table Orden_Seguimiento
add foreign key (id_orden_FK) references Orden(id_orden)
go

alter table Orden_Seguimiento
add id_usuario_FK numeric(10,0) not null
alter table Orden_Seguimiento
add foreign key (id_usuario_FK) references Usuario(id_usuario)
go

select *from Estado_Orden

insert into Estado_Orden(estado_orden)
values ('ACTIVA'),
('FINALIZADA');

select *from Orden

insert into Prioridad(desc_prioridad)
values ('ALTA'),
('MEDIA'),
('BAJA');

select *from Prioridad

Use OrdenesTrabajo

Alter Table Equipo DROP COLUMN serie_equipo;
Alter Table Equipo DROP COLUMN serialRAM1;
Alter Table Equipo DROP COLUMN serialRAM2;
Alter Table Equipo DROP COLUMN serialCargador;
Alter Table Equipo DROP COLUMN serialBateria;

Select * from Equipo

Alter Table Equipo ADD serie_equipo varchar(20);
Alter Table Equipo ADD serialRAM1 varchar (20);
Alter Table Equipo ADD serialRAM2 varchar (20);
Alter Table Equipo ADD serialCargador varchar (20);
Alter Table Equipo ADD serialBateria varchar (20);

Alter Table Orden Drop Column fecha_ingreso;
Alter Table Orden Drop Column fecha_salida;

Alter Table Orden Add fecha_ingreso varchar(20);
Alter Table Orden Add fecha_salida varchar(20);

Alter Table Usuario Drop Column rol;
Alter Table Usuario Add rol varchar(20);




