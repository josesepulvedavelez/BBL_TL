
create database bll_tl_test;
GO

use bll_tl_test;
GO

create table TipoEquipo
(
	TipoEquipoId uniqueidentifier default newid() primary key,
	Nombre varchar(50) not null,
	Descripcion varchar(200) not null
);

create table Equipo
(
	EquipoId uniqueidentifier default newid() primary key,
	Nombre varchar(50) not null,

	TipoEquipoId uniqueidentifier foreign key references TipoEquipo(TipoEquipoId) not null
);

create table Usuario
(
	UsuarioId uniqueidentifier default newid() primary key,
	Nombre varchar(50) not null,
	Apellido varchar(50) not null,
	Email varchar(100) not null,
	NumeroTelefono varchar(15) not null,
	Rol int not null,
	Credenciales varchar(10) not null,

	EquipoId uniqueidentifier foreign key references Equipo(EquipoId) not null
);

create table TipoIncidente
(
	TipoIncidenteId uniqueidentifier default newid() primary key,
	Nombre varchar(50) not null,
	Descripcion varchar(200) not null
);

create table Incidente
(
	IncidenteId uniqueidentifier default newid() primary key,
	Titulo varchar(100) not null,
	Descripcion varchar(500) not null,
	NivelSeveridad int not null,
	Estado int not null,
	FechaHoraInicio datetime not null,
	FechaHoraFin datetime null,
	Ubicacion varchar(200) not null,
	Coordenadas decimal(18, 9) not null,

	TipoIncidenteId uniqueidentifier foreign key references TipoIncidente(TipoIncidenteId) not null,
	UsuarioId uniqueidentifier foreign key references Usuario(UsuarioId) not null
);

create table Recurso
(
	RecursoId uniqueidentifier default newid() primary key,
	Nombre varchar(100) not null,
	Descripcion varchar(200) not null,
	CantidadDisponible int not null,
	Ubicacion varchar(200) not null,

	IncidenteId uniqueIdentifier foreign key references Incidente(IncidenteId) null
);

create table IncidenteEquipo
(
	EquipoId UNIQUEIDENTIFIER,
    IncidenteId UNIQUEIDENTIFIER,
    PRIMARY KEY (EquipoId, IncidenteId),

    FOREIGN KEY (EquipoId) REFERENCES Equipo(EquipoId),
    FOREIGN KEY (IncidenteId) REFERENCES Incidente(IncidenteId)
);

create table IncidenteRecurso
(
	RecursoId uniqueidentifier,
	IncidenteId uniqueidentifier,
	primary key(RecursoId, IncidenteId),

	foreign key (RecursoId) references Recurso(RecursoId),
	foreign key (IncidenteId) references Incidente(IncidenteId)
);
