use master
go
create database DB_ARTICULOS
go
use DB_ARTICULOS
go
create table categoria(
	idcategoria integer primary key identity,
	nombre varchar(50) not null unique,
	descripcion varchar(255) null,
	estado bit default(1)
);
go

insert into categoria (nombre,descripcion) 
values ('Equipos de sonido','Todos los equipos de sonido');
go

create table producto(
	idproducto integer primary key identity,
	idcategoria integer not null,
	codigo varchar(64) null,
	nombre varchar(100) not null unique,
	precio_venta decimal(11,2) not null,
	stock integer not null,
	descripcion varchar(255) null,
	estado bit default(1),
	FOREIGN KEY (idcategoria) REFERENCES categoria(idcategoria)
);
go

insert into producto (idcategoria,codigo,nombre,precio_venta,stock,descripcion) values(1,'000001','Mini Componente LA2000',1500.00,12,'Sony con conexión USB')
insert into producto (idcategoria,codigo,nombre,precio_venta,stock,descripcion) values(1,'000002','Mini Componente LA2001',1800.00,10,'Sony con conexión Bluetooth')
insert into producto (idcategoria,codigo,nombre,precio_venta,stock,descripcion) values(1,'000003','Mini Componente LA2002',2000.00,5,'Sony con conexión Wifi')
insert into producto (idcategoria,codigo,nombre,precio_venta,stock,descripcion) values(1,'000004','Mini Componente LA2003',2500.00,8,'Sony con conexión USB+Bluetooth')
insert into producto (idcategoria,codigo,nombre,precio_venta,stock,descripcion) values(1,'000005','Mini Componente LA2004',3000.00,3,'Sony con conexión USB+Bluetooth+Wifi')