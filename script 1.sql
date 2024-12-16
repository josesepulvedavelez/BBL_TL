
CREATE DATABASE BBL_TL;

USE BBL_TL;

CREATE TABLE TipoIncidente (
    TipoIncidenteId UNIQUEIDENTIFIER PRIMARY KEY,
    Nombre NVARCHAR(50) NOT NULL,
    Descripcion NVARCHAR(200) NULL
);

CREATE TABLE TipoEquipo (
    TipoEquipoId UNIQUEIDENTIFIER PRIMARY KEY,
    Nombre NVARCHAR(50) NOT NULL,
    Descripcion NVARCHAR(200) NULL
);

CREATE TABLE Equipo (
    EquipoId UNIQUEIDENTIFIER PRIMARY KEY,
    Nombre NVARCHAR(50) NOT NULL,
    TipoEquipoId UNIQUEIDENTIFIER NOT NULL,

    FOREIGN KEY (TipoEquipoId) REFERENCES TipoEquipo(TipoEquipoId)
);

CREATE TABLE Usuario (
    UsuarioId UNIQUEIDENTIFIER PRIMARY KEY,
    Nombre NVARCHAR(50) NOT NULL,
    Apellido NVARCHAR(50) NOT NULL,
    Email NVARCHAR(100) NOT NULL,
    NumeroTelefono NVARCHAR(15) NULL,
    Rol NVARCHAR(20) NOT NULL,
    EquipoId UNIQUEIDENTIFIER NULL,
    Credenciales NVARCHAR(MAX) NOT NULL,

    FOREIGN KEY (EquipoId) REFERENCES Equipo(EquipoId)
);

CREATE TABLE Incidente (
    IncidenteId UNIQUEIDENTIFIER PRIMARY KEY,
    Titulo NVARCHAR(100) NOT NULL,
    Descripcion NVARCHAR(500) NULL,
    TipoIncidenteId UNIQUEIDENTIFIER NOT NULL,
    NivelSeveridad NVARCHAR(20) NOT NULL,
    Estado NVARCHAR(20) NOT NULL,
    FechaHoraInicio DATETIME NOT NULL,
    FechaHoraFin DATETIME NULL,
    Ubicacion NVARCHAR(200) NULL,
    CoordenadasLatitude DECIMAL(9, 6) NULL,
    CoordenadasLongitude DECIMAL(9, 6) NULL,
    ReportadoPorUsuarioId UNIQUEIDENTIFIER NOT NULL,

    FOREIGN KEY (TipoIncidenteId) REFERENCES TipoIncidente(TipoIncidenteId),
    FOREIGN KEY (ReportadoPorUsuarioId) REFERENCES Usuario(UsuarioId)
);

CREATE TABLE Recurso (
    RecursoId UNIQUEIDENTIFIER PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULL,
    Descripcion NVARCHAR(200) NULL,
    CantidadDisponible INT NOT NULL,
    Ubicacion NVARCHAR(200) NULL,
    IncidenteIdAsignado UNIQUEIDENTIFIER NULL,

    FOREIGN KEY (IncidenteIdAsignado) REFERENCES Incidente(IncidenteId)
);

CREATE TABLE IncidenteEquipo (
    IncidenteId UNIQUEIDENTIFIER NOT NULL REFERENCES Incidente(IncidenteId),
    EquipoId UNIQUEIDENTIFIER NOT NULL REFERENCES Equipo(EquipoId),
    PRIMARY KEY (IncidenteId, EquipoId)
);

CREATE TABLE IncidenteRecurso (
    IncidenteId UNIQUEIDENTIFIER NOT NULL REFERENCES Incidente(IncidenteId),
    RecursoId UNIQUEIDENTIFIER NOT NULL REFERENCES Recurso(RecursoId),
    PRIMARY KEY (IncidenteId, RecursoId)
);

CREATE TABLE EquipoUsuario (
    EquipoId UNIQUEIDENTIFIER NOT NULL REFERENCES Equipo(EquipoId),
    UsuarioId UNIQUEIDENTIFIER NOT NULL REFERENCES Usuario(UsuarioId),
    PRIMARY KEY (EquipoId, UsuarioId)
);
