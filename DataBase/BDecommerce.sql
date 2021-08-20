use master 
go

if exists(Select * FROM SysDataBases WHERE name='BDecommerce')
BEGIN
DROP DATABASE BDecommerce
END
go

------------------------------------------------------------

create database BDecommerce
on
(
name = BDecommerce,
filename ='c:\BASE_DE_DATOS\BDecommerce.mdf'
)
go

------------------------------------------------------------

use BDecommerce
go

create table Usuario
(
Mail Varchar(25) not null primary key ,
Nombre varchar(25) not null,
Apellido varchar(25) not null,
FechaNac Date not null,
Direccion varchar(25) not null,
Localidad varchar(25) not null,
Cel varchar(25) not null,
Pw varchar(25) not null,
--TipoDeUsu varchar(25) not null
)
go

insert into Usuario(Mail, Nombre, Apellido, FechaNac, Direccion, Localidad, Cel, Pw ) values('ve364@gmail.com', 'Veronica', 'Rodriguez', '01-02-1965', 'moreira', 'La Paz', '096393389', '111111')
insert into Usuario(Mail, Nombre, Apellido, FechaNac, Direccion, Localidad, Cel, Pw  ) values('veer4@gmail.com', 'Lana', 'Martinez', '01/02/1989', 'moreira', 'La Paz', '098393389', '111111')
insert into Usuario(Mail, Nombre, Apellido, FechaNac, Direccion, Localidad, Cel, Pw ) values('veero364@gmail.com', 'Mario', 'Madejo', '01-02-2000', 'moreira', 'La Paz', '097593389', '111111')
go

--drop table Usuario
select * from Usuario
--**************************PROCEDIMIENTOS*************************--
create procedure Logueo
@Mail varchar(25),
@Pw varchar(25)
AS
Begin
	Select * 
	From Usuario u 
	Where u.Mail = @Mail and u.Pw = @Pw
End
go