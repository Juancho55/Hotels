USE HOTEL
GO

INSERT INTO DOCUMENTTYPE (Nombre, Activo)
SELECT 'C.C.',1 UNION ALL
SELECT 'PAS',1 

INSERT INTO GENDER (Nombre, Actibvo)
SELECT 'M', 1 UNION ALL
SELECT 'F', 1 

INSERT INTO THIRDTYPE(Nombre, Activo)
SELECT 'Agente', 1 UNION ALL
SELECT 'Cliente', 1 UNION ALL
SELECT 'Contacto', 1

INSERT INTO ROL(Nombre, Activo)
SELECT 'Interno', 1 UNION ALL
SELECT 'Externo', 1

DECLARE @ThirdType INT, @GeneroId INT, @TipoDocumentoId INT

SELECT @GeneroId = Id FROM GENDER WHERE Nombre = 'M'
SELECT @TipoDocumentoId = Id FROM DOCUMENTTYPE WHERE Nombre = 'C.C.'
SELECT @ThirdType = Id FROM THIRDTYPE WHERE Nombre = 'Agente'

INSERT INTO Third(PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, FechNacimiento, GeneroId, TipoDocumento, NumeroDocumento, Email, TelefonoContato, ThirdTypeId)
SELECT 'Juan', 'David', 'Layton', '', '03-10-1990', @GeneroId, @TipoDocumentoId, 1081406091, 'juanlayton@misena.edu.co', '315854765', @ThirdType



