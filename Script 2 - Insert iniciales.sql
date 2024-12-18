INSERT INTO TipoEquipo(Nombre, Descripcion) VALUES('TIPO EQUIPO 1', 'TIPO EQUIPO 1');
GO
INSERT INTO TipoEquipo(Nombre, Descripcion) VALUES('TIPO EQUIPO 2', 'TIPO EQUIPO 2');
GO

DECLARE @TipoEquipoId1 UNIQUEIDENTIFIER;
	SET @TipoEquipoId1 = (SELECT TOP 1 TipoEquipoId FROM TipoEquipo WHERE Nombre = 'TIPO EQUIPO 1');
	INSERT INTO Equipo(Nombre, TipoEquipoId) VALUES('EQUIPO 1', @TipoEquipoId1);

DECLARE @TipoEquipoId2 UNIQUEIDENTIFIER;
	SET @TipoEquipoId2 = (SELECT TOP 1 TipoEquipoId FROM TipoEquipo WHERE Nombre = 'TIPO EQUIPO 2');
	INSERT INTO Equipo(Nombre, TipoEquipoId) VALUES('EQUIPO 2', @TipoEquipoId2);


DECLARE @EquipoId1 UNIQUEIDENTIFIER;
	SET @EquipoId1 = (SELECT TOP 1 EquipoId FROM Equipo WHERE TipoEquipoId = @TipoEquipoId1);
	INSERT INTO Usuario (Nombre, Apellido, Email, NumeroTelefono, Rol, Credenciales, EquipoId) VALUES ('Carlos', 'Perez', 'carlos.perez@hotmail.com', '1234567890', 1, 'cred123', @EquipoId1);

DECLARE @EquipoId2 UNIQUEIDENTIFIER;
	SET @EquipoId2 = (SELECT TOP 1 EquipoId FROM Equipo WHERE TipoEquipoId = @TipoEquipoId2);
	INSERT INTO Usuario (Nombre, Apellido, Email, NumeroTelefono, Rol, Credenciales, EquipoId) VALUES ('Maria', 'Gomez', 'maria.gomez@gmail.com', '9876543210', 2, 'cred456', @EquipoId2);
	INSERT INTO Usuario (Nombre, Apellido, Email, NumeroTelefono, Rol, Credenciales, EquipoId) VALUES ('Luis', 'Lopez', 'luis.lopez@gmail.com', '1231231234', 2, 'cred789', @EquipoId2);

INSERT INTO TipoIncidente(Nombre, Descripcion) VALUES('INCENDIO', 'INCENDIO');
INSERT INTO TipoIncidente(Nombre, Descripcion) VALUES('LLUVIA', 'LLUVIA');
