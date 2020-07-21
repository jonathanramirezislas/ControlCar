create database EmpresaDeVehiculosJONAS
use EmpresaDeVehiculosJONAS



create table color(
id_color varchar(50) Not null,
nombre_color varchar(50) Not nULL,
primary key(id_color)
)
  insert into color  values ('C1','Negro')
  insert into color  values ('C2','Blanco')
  insert into color  values ('C3','Azul')
   insert into color  values ('C4','Plateado')
   insert into color  values ('C5','Verde')
   insert into color  values ('C6','Morado')

create table Marca(
id_Marca varchar(50) Not null,
nombre_Marca varchar(50) Not nULL,
primary key(id_Marca)
)
 insert into Marca  values ('M1','Chevrolet')
  insert into Marca  values ('M2','Hyundai')
  insert into Marca  values ('M3','Ford')
   insert into Marca  values ('M4','Dodge')
   insert into Marca  values ('M5','Bmw')
   insert into Marca  values ('M6','Mazda')
   insert into Marca  values ('M7','Volkswagen')
   insert into Marca  values ('M8','Jeep')
   insert into Marca  values ('M9','Mitsubishi')

create table Tipo(
id_Tipo varchar(50) Not null,
nombre_Tipo varchar(50) Not nULL,
primary key(id_Tipo)
)

insert into Tipo  values ('T1','Automovil')
  insert into Tipo  values ('T2','Camioneta')
  insert into Tipo  values ('T3','Camion')
   insert into Tipo  values ('T4','Van')
   

create table Provedor(
id_Provedor varchar(50) Not null,
nombre_Provedor varchar(50) Not nULL,
primary key(id_Provedor)
)
insert into Provedor  values ('P1','Jonas')
insert into Provedor  values ('p2','Alejandro')
insert into Provedor  values ('p3','Luis')
insert into Provedor  values ('p4','Job')



create table Automovil(
Placas varchar(10) ,
Modelo varchar(40),
Año_de_Fabricacion varchar(20) ,
Precio varchar(50)Not null,
Num_Puertas int,
Num_Cilidros int,
lujo varchar(5),
activo int ,

------------
primary key(Placas),
 id_color varchar(50) FOREIGN KEY  REFERENCES color(id_color),
id_Marca varchar(50) FOREIGN KEY  REFERENCES Marca(id_Marca),
id_Tipo varchar(50) FOREIGN KEY REFERENCES Tipo(id_Tipo)
)

CREATE TABLE CARGAS(
cargalitros float,
Monto_De_Carga varchar(200),
Fecha_De_Cargayhora datetime,
KilometrajeRecorrido BIGint,
Kilometrajetotal BigINt,
rendimiento float,
UltimaCarga int,
id_Provedor varchar(50) FOREIGN KEY  REFERENCES Provedor(id_Provedor),
Placas varchar(10) FOREIGN KEY  REFERENCES Automovil (Placas),
)


 SELECT count(Placas) from CARGAS where Placas='dsfdsf'


 insert into Cargas(cargalitros,Monto_De_Carga,Fecha_De_Cargayhora,KilometrajeRecorrido,rendimiento,UltimaCarga,id_Provedor,Placas) Values(45,1000,'10/10/2017 12:00:00',5,4,1,'P1','AA03')
use master 
drop database EmpresaDeVehiculosJONAS

Select Placas,Ma.nombre_Marca,Ti.nombre_Tipo,Co.nombre_color from Automovil Au INNER JOIN Marca Ma on Au.id_Marca=Ma.id_Marca
 Inner join Tipo Ti on Au.id_Tipo= Ti.id_Tipo INNER JOIN color Co on Au.id_color=Co.id_color  Where Placas = 'AA03'

 insert into Cargas(cargalitros,Monto_De_Carga,Fecha_De_Cargayhora,KilometrajeRecorrido,rendimiento,UltimaCarga,id_Provedor,Placas) Values(45,1000,'22/10/2017 12:00:00',5,4,1,'P1','AA03')

 SELECT Max(Fecha_De_Cargayhora) FROM Cargas  where Placas='AA03' 
 
 
 SELECT *
FROM Cargas
WHERE Fecha_De_Cargayhora = ( 
SELECT MAX( Fecha_De_Cargayhora )  FROM Cargas ) AND  Placas='AA03'

select Placas,Ma.nombre_Marca,TI.nombre_Tipo,Po.nombre_Provedor,Monto_De_Carga,cargalitros,Fecha_De_Cargayhora,Kilometrajetotal,KilometrajeRecorrido,rendimiento FROM  Cargas Ca INNER JOIN Provedor Po on Ca.id_Provedor=Po.id_Provedor  INNER JOIN Automovil Au on Ca.Placas=Au.Placas INNER JOIN  Marca Ma on AU.id_Marca.Placas=Ma.id_Marca   INNER JOIN   Tipo  TI on Au.id_Tipo=TI.id_Tipo  where   UltimaCarga =1


Select Placas,Po.nombre_Provedor,cargalitros,Monto_De_Carga,Fecha_De_Cargayhora,KilometrajeRecorrido,rendimiento FROM  Cargas Ca INNER JOIN Provedor Po on Ca.id_Provedor=Po.id_Provedor where Placas='AA03'