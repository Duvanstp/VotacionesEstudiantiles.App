create database VotacionesEstudiantiles;

use VotacionesEstudiantiles; 

create table Estudiante(
	id integer IDENTITY(1,1) PRIMARY KEY, 
	nombre text, 
	apellido text, 
	grado integer, 
	curso integer,
	estado_voto integer
);

create table Candidatos(
	id integer IDENTITY(1,1) PRIMARY KEY,
	cargo text, 
	estudiante_id integer,
	Foreign key (estudiante_id) References Estudiante(id)
);

create table Votos(
	id integer IDENTITY(1,1) PRIMARY KEY,  
	candidato_id integer, 
	Foreign key (candidato_id) References Candidatos(id)
);

create table Administrador(
	id integer IDENTITY(1,1) PRIMARY KEY,
	nombre text, 
	apellido text, 
	usuario text, 
	contrasena text
);

select * from Administrador;