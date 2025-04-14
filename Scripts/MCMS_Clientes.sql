
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF OBJECT_ID('MCMS__Clientes_GetInfo') IS NOT NULL
BEGIN
	DROP PROCEDURE MCMS__Clientes_GetInfo
END
GO

CREATE PROCEDURE MCMS__Clientes_GetInfo 
(
	 @FilNombreClie NVARCHAR(1000),
	 @FilTelefono INT,
	 @FilCorreo NVARCHAR(100),
	 @FilIdentifiacion INT,
	 @FilArti_vendi NVARCHAR(1000),
	 @FilReferencia NVARCHAR(1000),
	 @FilComision BIT
)AS
BEGIN
	SELECT * 
	INTO #TempClie
	FROM METACLIE
	ORDER BY Id

	IF LEN(@FilNombreClie) <> 0
	BEGIN
		DELETE #TempClie WHERE Nombre_clie NOT LIKE '%' + @FilNombreClie + '%'
	END
	IF @FilTelefono <> 0
	BEGIN
		DELETE #TempClie WHERE CAST(Telefono AS NVARCHAR) NOT LIKE '%' + CAST(@FilTelefono AS NVARCHAR) + '%'
	END
	IF LEN(@FilCorreo) <> 0
	BEGIN
		DELETE #TempClie WHERE Correo NOT LIKE '%' + @FilCorreo + '%'
	END
	IF @FilIdentifiacion <> 0
	BEGIN
		DELETE #TempClie WHERE CAST(Identificacion AS nvarchar) NOT LIKE '%' + CAST(@FilIdentifiacion AS nvarchar) + '%'
	END
	IF LEN(@FilArti_vendi) <> 0
	BEGIN
		DELETE #TempClie WHERE Arti_vendi NOT LIKE '%' + @FilArti_vendi + '%'
	END
	IF LEN(@FilReferencia) <> 0
	BEGIN
		DELETE #TempClie WHERE Referencia NOT LIKE '%' + @FilReferencia + '%'
	END
	IF @FilComision = 1
	BEGIN
		DELETE #TempClie WHERE Comision = 0
	END

	SELECT *, CASE Comision WHEN 1 THEN 'Si' ELSE 'No' END Comi
	FROM #TempClie
END
GO

-------------------------------------------------
-------------------------------------------------

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

IF OBJECT_ID('MCMS_Clientes_PutInfo') IS NOT NULL
BEGIN
	DROP PROCEDURE MCMS_Clientes_PutInfo
END
GO

CREATE PROCEDURE MCMS_Clientes_PutInfo
(
	   @Id_clie INT,
	   @NombreClie NVARCHAR(1000),
	   @Telefono INT, 
	   @Correo NVARCHAR(100), 
	   @Identificacion INT, 
	   @Arti_vendi NVARCHAR(1000), 
	   @Referencia NVARCHAR(1000), 
	   @Comision BIT,
	   @vEliminado BIT
)
AS
BEGIN

	SET XACT_ABORT ON
	BEGIN TRANSACTION PutClie

	IF @vEliminado = 0 -- Crear
	BEGIN
		
		IF @Id_clie = 0 -- Crear
		BEGIN
			INSERT INTO METACLIE
			SELECT @NombreClie,@Telefono,@Correo,@Identificacion,@Arti_vendi,@Referencia,@Comision

			SET @Id_clie = @@IDENTITY
		END
		ELSE -- Editar
		BEGIN	
			UPDATE METACLIE
			SET Nombre_clie = @NombreClie,
				Telefono = @Telefono,
				Correo = @Correo,
				Identificacion = @Identificacion,
				Arti_vendi = @Arti_vendi,
				Referencia = @Referencia,
				Comision = @Comision
		END

	END
	ELSE -- Eliminar
	BEGIN
		DELETE METACLIE WHERE Id = @Id_clie
	END
	
	SELECT @Id_clie Id

	COMMIT TRANSACTION PutClie

END