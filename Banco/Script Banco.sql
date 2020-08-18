create database bancotcc;
use bancotcc;

create table USUARIO(
Id_Usu int(4) auto_increment primary key, 
LOGIN varchar(20) not null,
SENHA varchar(15) not null);

create table DENUNCIA(
ID_Denun int(5) auto_increment primary key,
Nome varchar(50),
CPF varchar(14) ,
Data date not null,
Tipo varchar(50) not null,
Local varchar(75) not null,
Descricao varchar(300) not null,
Ponto_Refe varchar(30) not null,
Status varchar(12));

insert into denuncia values(
null,
'Henrique',
'44355344224',
'2018-06-24',
'Queimada',
'Rua Joaquim Marcelino Leite',
'Terreno vazio encontrado com coisas queimando',
'Perto do Villa Flora',
'Aberto'); -- Id_denuncia

select * from denuncia where nome='Henrique';
SELECT * FROM DENUNCIA WHERE NOME='Henrique';

delete from denuncia where id_denun = 14;
drop table denuncia;
select * from denuncia where id_denun = 3;

