create database bd;
use bd;
drop database bd;
create table usuarios(
userid int auto_increment primary key,
Login varchar(100) not null,
Nombre varchar(100) not null,
Paterno varchar(100) not null,
Materno varchar(100) not null
);

create table empleados(
userid int auto_increment primary key,
Sueldo double not null,
FechaIngreso Date not null,
userid_usuarios  int,
foreign key (userid_usuarios) references usuarios(userid) on delete cascade on update cascade 
);

insert into usuarios (userid,Login, Nombre, Paterno, Materno) values(0,'user01','BERE','NARANJO','GONZALEZ');
insert into usuarios (userid,Login, Nombre, Paterno, Materno) values(0,'user02','ALEXIS','CAMPOS','NARANJO');
insert into usuarios (userid,Login, Nombre, Paterno, Materno) values(0,'user03','SERGIO ALEJANDRO','CAMPOS','HERNANDEZ');
insert into usuarios (userid,Login, Nombre, Paterno, Materno) values(0,'user04','DIEGO ISMAEL','BERUMEN','CEDILLO');
insert into usuarios (userid,Login, Nombre, Paterno, Materno) values(0,'user05','AURORA','ESCALANTE','PALAFOX');
insert into usuarios (userid,Login, Nombre, Paterno, Materno) values(0,'user06','JOYCELENE FABIOLA','ESTRADA','BARBA');
insert into usuarios (userid,Login, Nombre, Paterno, Materno) values(0,'user07','FRANCISCO','ESTRADA','GOMEZ');
insert into usuarios (userid,Login, Nombre, Paterno, Materno) values(0,'user08','LEONARDO DANIEL','FARIAS','ROSAS');
insert into usuarios (userid,Login, Nombre, Paterno, Materno) values(0,'user09','RAMON ANDRES','FIERROS','ROBLES');
insert into usuarios (userid,Login, Nombre, Paterno, Materno) values(0,'user10','EDGAR ANDRES','FLORES','OLIVARES');
insert into usuarios (userid,Login, Nombre, Paterno, Materno) values(0,'user11','MARIA FERNANDA','FRANCO','ESQUIVEL');
insert into usuarios (userid,Login, Nombre, Paterno, Materno) values(0,'user12','ALEJANDRO','GALVAN','MUÑIZ');
insert into usuarios (userid,Login, Nombre, Paterno, Materno) values(0,'user13','MARTHA ALICIA','GUTIERREZ','ORTIZ');
insert into usuarios (userid,Login, Nombre, Paterno, Materno) values(0,'user14','JOSAFAT GERARDO','HERNANDEZ','SAUCEDO');
insert into usuarios (userid,Login, Nombre, Paterno, Materno) values(0,'user15','ROSALIA','JIMENEZ','GONZALEZ');
insert into usuarios (userid,Login, Nombre, Paterno, Materno) values(0,'user16','LAURA CELENE','JIMENEZ','RIOS');
insert into usuarios (userid,Login, Nombre, Paterno, Materno) values(0,'user17','ANGELICA','LOPEZ','CORTES');
insert into usuarios (userid,Login, Nombre, Paterno, Materno) values(0,'user18','CRISTIAN IVAN','LOPEZ','GOMEZ');
insert into usuarios (userid,Login, Nombre, Paterno, Materno) values(0,'user19','MARLENE GABRIELA','LOPEZ','MEZA');
insert into usuarios (userid,Login, Nombre, Paterno, Materno) values(0,'user20','ALEJANDRA','MEDINA','IBARRA');
insert into usuarios (userid,Login, Nombre, Paterno, Materno) values(0,'user21','CONSUELO YURIDIANA THALIA','MEJIA','ALVAREZ');
insert into usuarios (userid,Login, Nombre, Paterno, Materno) values(0,'user22','JAVIER ADRIAN','MEJIA','ALVAREZ');
insert into usuarios (userid,Login, Nombre, Paterno, Materno) values(0,'user23','JUAN CARLOS EVARISTO','PEÑA','GUTIERREZ');
insert into usuarios (userid,Login, Nombre, Paterno, Materno) values(0,'user24','JAZMIN ALEJANDRA','PEREZ','VELEZ');
insert into usuarios (userid,Login, Nombre, Paterno, Materno) values(0,'user25','GUSTAVO','RAMIREZ','RIVERA');
insert into usuarios (userid,Login, Nombre, Paterno, Materno) values(0,'user26','CARLOS NIVARDO','RODRIGUEZ','ASCENCIO');
insert into usuarios (userid,Login, Nombre, Paterno, Materno) values(0,'user27','KARLA JOHANA','ROMERO','LUEVANOS');
insert into usuarios (userid,Login, Nombre, Paterno, Materno) values(0,'user28','YESSICA YOSELINNE','RUIZ','HERNANDEZ');
insert into usuarios (userid,Login, Nombre, Paterno, Materno) values(0,'user29','CHRISTIAN EDUARDO','SALAS','SANCHEZ');
insert into usuarios (userid,Login, Nombre, Paterno, Materno) values(0,'user30','LUIS ROBERTO','SALDAÑA','ESPINOZA');
insert into usuarios (userid,Login, Nombre, Paterno, Materno) values(0,'user31','ADRIAN','SANCHEZ','ORTIZ');
insert into usuarios (userid,Login, Nombre, Paterno, Materno) values(0,'user32','EDUARDO YAIR','SUAREZ','HERNANDEZ');
insert into usuarios (userid,Login, Nombre, Paterno, Materno) values(0,'user33','JUAN FRANCISCO','TABAREZ','GARCIA');
insert into usuarios (userid,Login, Nombre, Paterno, Materno) values(0,'user34','ZULEICA ELIZABETH','TERAN','TORRES');
insert into usuarios (userid,Login, Nombre, Paterno, Materno) values(0,'user35','ADRIANA YUNUHEN','VARGAS','AYALA');
insert into usuarios (userid,Login, Nombre, Paterno, Materno) values(0,'user36','OSCAR URIEL','VELAZQUEZ','ALVAREZ');
insert into usuarios (userid,Login, Nombre, Paterno, Materno) values(0,'user37','ERICK DE JESUS','CORONA','DIAZ');
insert into usuarios (userid,Login, Nombre, Paterno, Materno) values(0,'user38','MARIA GUADALUPE','RAMOS','HERNANDEZ');
insert into usuarios (userid,Login, Nombre, Paterno, Materno) values(0,'user39','JESSICA NOEMI','JIMENEZ','VENTURA');
insert into usuarios (userid,Login, Nombre, Paterno, Materno) values(0,'user40','FLOR MARGARITA','ROJAS','HERNANDEZ');
insert into usuarios (userid,Login, Nombre, Paterno, Materno) values(0,'user41','LUIS ANTONIO','ALVARADO','VALENCIA');
insert into usuarios (userid,Login, Nombre, Paterno, Materno) values(0,'user42','EDGAR IVAN','AGUILAR','PADILLA');
insert into usuarios (userid,Login, Nombre, Paterno, Materno) values(0,'user43','LUIS ALFONSO','MICHEL','ROCHA');
insert into usuarios (userid,Login, Nombre, Paterno, Materno) values(0,'user44','JOSE CARLOS','SILVA','GONZALEZ');
insert into usuarios (userid,Login, Nombre, Paterno, Materno) values(0,'user45','JUDITH','RODRIGUEZ','REYES');
insert into usuarios (userid,Login, Nombre, Paterno, Materno) values(0,'user46','BRENDA SORAYA','CHAVEZ','GARCIA');


insert into empleados(userid, Sueldo, FechaIngreso, userid_usuarios) values(0, 8837.00, '2000-01-11',1);
insert into empleados(userid, Sueldo, FechaIngreso, userid_usuarios) values(0, 8837.00, '2000-01-11',2);
insert into empleados(userid, Sueldo, FechaIngreso, userid_usuarios) values(0, 15000.00, '2000-01-11',3);
insert into empleados(userid, Sueldo, FechaIngreso, userid_usuarios) values(0, 15000.00, '2000-01-11',4);
insert into empleados(userid, Sueldo, FechaIngreso, userid_usuarios) values(0, 7812.00, '2000-01-18',5);
insert into empleados(userid, Sueldo, FechaIngreso, userid_usuarios) values(0, 7812.00, '2000-01-18',6);
insert into empleados(userid, Sueldo, FechaIngreso, userid_usuarios) values(0, 10200.00, '2000-01-18',7);
insert into empleados(userid, Sueldo, FechaIngreso, userid_usuarios) values(0, 10200.00, '2000-01-18',8);
insert into empleados(userid, Sueldo, FechaIngreso, userid_usuarios) values(0, 13800.00, '2001-05-20',9);
insert into empleados(userid, Sueldo, FechaIngreso, userid_usuarios) values(0, 13800.00, '2001-05-20',10);
insert into empleados(userid, Sueldo, FechaIngreso, userid_usuarios) values(0, 18880.00, '2001-05-20',11);
insert into empleados(userid, Sueldo, FechaIngreso, userid_usuarios) values(0, 18880.00, '2001-05-20',12);
insert into empleados(userid, Sueldo, FechaIngreso, userid_usuarios) values(0, 8000.00, '2001-07-13',13);
insert into empleados(userid, Sueldo, FechaIngreso, userid_usuarios) values(0, 8000.00, '2001-07-13',14);
insert into empleados(userid, Sueldo, FechaIngreso, userid_usuarios) values(0, 6000.00, '2001-07-13',15);
insert into empleados(userid, Sueldo, FechaIngreso, userid_usuarios) values(0, 19470.00, '2001-07-13',16);
insert into empleados(userid, Sueldo, FechaIngreso, userid_usuarios) values(0, 19470.00, '2001-07-13',17);
insert into empleados(userid, Sueldo, FechaIngreso, userid_usuarios) values(0, 10200.00, '2001-07-16',18);
insert into empleados(userid, Sueldo, FechaIngreso, userid_usuarios) values(0, 10200.00, '2001-07-16',19);
insert into empleados(userid, Sueldo, FechaIngreso, userid_usuarios) values(0, 25000.00, '2001-07-16',20);
insert into empleados(userid, Sueldo, FechaIngreso, userid_usuarios) values(0, 7812.00, '2001-07-16',21);
insert into empleados(userid, Sueldo, FechaIngreso, userid_usuarios) values(0, 7812.00, '2001-07-16',22);
insert into empleados(userid, Sueldo, FechaIngreso, userid_usuarios) values(0, 12210.00, '2001-11-24',23);
insert into empleados(userid, Sueldo, FechaIngreso, userid_usuarios) values(0, 12210.00, '2001-11-24',24);
insert into empleados(userid, Sueldo, FechaIngreso, userid_usuarios) values(0, 7500.00, '2001-11-24',25);
insert into empleados(userid, Sueldo, FechaIngreso, userid_usuarios) values(0, 15020.00, '2001-11-24',26);
insert into empleados(userid, Sueldo, FechaIngreso, userid_usuarios) values(0, 15020.00, '2001-11-24',27);
insert into empleados(userid, Sueldo, FechaIngreso, userid_usuarios) values(0, 25000.00, '2001-11-24',28);
insert into empleados(userid, Sueldo, FechaIngreso, userid_usuarios) values(0, 7812.00, '2001-11-24',29);
insert into empleados(userid, Sueldo, FechaIngreso, userid_usuarios) values(0, 15020.00, '2001-12-12',30);
insert into empleados(userid, Sueldo, FechaIngreso, userid_usuarios) values(0, 15020.00, '2001-12-12',31);
insert into empleados(userid, Sueldo, FechaIngreso, userid_usuarios) values(0, 12210.00, '2001-12-12',32);
insert into empleados(userid, Sueldo, FechaIngreso, userid_usuarios) values(0, 12210.00, '2001-12-12',33);
insert into empleados(userid, Sueldo, FechaIngreso, userid_usuarios) values(0, 19470.00, '2008-08-17',34);
insert into empleados(userid, Sueldo, FechaIngreso, userid_usuarios) values(0, 19470.00, '2008-08-17',35);
insert into empleados(userid, Sueldo, FechaIngreso, userid_usuarios) values(0, 8000.00, '2008-08-17',36);
insert into empleados(userid, Sueldo, FechaIngreso, userid_usuarios) values(0, 8000.00, '2008-08-17',37);
insert into empleados(userid, Sueldo, FechaIngreso, userid_usuarios) values(0, 18880.00, '2009-06-11',38);
insert into empleados(userid, Sueldo, FechaIngreso, userid_usuarios) values(0, 18880.00, '2009-06-11',39);
insert into empleados(userid, Sueldo, FechaIngreso, userid_usuarios) values(0, 14000.00, '2009-06-11',40);
insert into empleados(userid, Sueldo, FechaIngreso, userid_usuarios) values(0, 18880.00, '2009-06-11',41);
insert into empleados(userid, Sueldo, FechaIngreso, userid_usuarios) values(0, 18880.00, '2009-06-11',42);
insert into empleados(userid, Sueldo, FechaIngreso, userid_usuarios) values(0, 15000.00, '2009-10-06',43);
insert into empleados(userid, Sueldo, FechaIngreso, userid_usuarios) values(0, 15000.00, '2009-10-06',44);
insert into empleados(userid, Sueldo, FechaIngreso, userid_usuarios) values(0, 13000.00, '2009-10-06',45);
insert into empleados(userid, Sueldo, FechaIngreso, userid_usuarios) values(0, 8837.00, '2009-10-06',46);

-- 1
delete from usuarios where id != 6 and id != 7 and id != 9 and id != 10;

-- 2
update usuarios set Sueldo = Sueldo + (Sueldo * .10) where FechaIngreso between '2000/01/01' and '2001/12/31';
update empleados set Sueldo = 12000, FechaIngreso = '2000-10-10' where userid = 1;
-- 3
select u.Nombre, e.FechaIngreso from usuarios u, empleados e where u.userid = e.userid and Sueldo > 10000 and u.Paterno like 'T%';

-- 4
select count(*) as Menor, (select count(*) as Mayor from empleados where Sueldo > 12000) from empleados where sueldo < 12000;

