USE [Cave_Vins]
GO
/****** Object:  StoredProcedure [dbo].[NbEmplacementsOQPSaufIdBtl]    Script Date: 03/03/2013 13:26:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Jean Traullé
-- Create date: 09/02/2013
-- Description:	Procédure permettant de retourner le nombre d'emplacements qui possèdent une ou des bouteilles ayant un id différent de celui passé en paramètre
-- =============================================
CREATE PROCEDURE [dbo].[NbEmplacementsOQPSaufIdBtl] 
	-- Add the parameters for the stored procedure here
	@idLieu int = 0, 
	@idBouteille int = 0
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT COUNT(DISTINCT(T_STOCKAGE_STO.EMP_I_ID))
	FROM         T_STOCKAGE_STO 
	INNER JOIN   T_EMPLACEMENT_EMP ON T_STOCKAGE_STO.EMP_I_ID = T_EMPLACEMENT_EMP.EMP_I_ID
	WHERE		 T_EMPLACEMENT_EMP.LIE_I_ID = @idLieu
	AND			 T_STOCKAGE_STO.BTL_I_ID <> @idBouteille
END
GO
/****** Object:  StoredProcedure [dbo].[NbBouteillesInLieuByIdBtl]    Script Date: 03/03/2013 13:26:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Jean Traullé
-- Create date: 10/02/2013
-- Description:	Procédure permettant de retourner le nombre de bouteilles d'un certain Id présentent dans un certain lieu.
-- =============================================
CREATE PROCEDURE [dbo].[NbBouteillesInLieuByIdBtl] 
	-- Add the parameters for the stored procedure here
	@idLieu int = 0, 
	@idBouteille int = 0
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT ISNULL(
	(
		SELECT     SUM(T_STOCKAGE_STO_1.STO_I_QTE) AS Expr1
		FROM         T_EMPLACEMENT_EMP INNER JOIN
							  T_STOCKAGE_STO AS T_STOCKAGE_STO_1 ON T_EMPLACEMENT_EMP.EMP_I_ID = T_STOCKAGE_STO_1.EMP_I_ID
		GROUP BY T_EMPLACEMENT_EMP.LIE_I_ID, T_STOCKAGE_STO_1.BTL_I_ID
		HAVING      (T_EMPLACEMENT_EMP.LIE_I_ID = @idLieu) AND (T_STOCKAGE_STO_1.BTL_I_ID = @idBouteille)
	), 0)  AS Nb
END
GO
/****** Object:  StoredProcedure [dbo].[NbBouteillesInEmplacementsFromLieu]    Script Date: 03/03/2013 13:26:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NbBouteillesInEmplacementsFromLieu]
      @ID int
      AS
      SELECT     T_STOCKAGE_STO.EMP_I_ID AS EmpID, T_BOUTEILLE_BTL.BTL_I_ID AS IdBtl, T_CHATEAU_CHT.CHT_S_CHATEAU AS Cha, T_BOUTEILLE_BTL.BTL_I_MILLESIME AS Mil, T_EMPLACEMENT_EMP.EMP_I_POSH AS X, T_EMPLACEMENT_EMP.EMP_I_POSV AS Y,
                      SUM(T_STOCKAGE_STO.STO_I_QTE) AS Qte, T_LIEU_LIE.LIE_I_CAPA - SUM(T_STOCKAGE_STO.STO_I_QTE) AS Dispo
FROM         T_STOCKAGE_STO INNER JOIN
                      T_EMPLACEMENT_EMP ON T_STOCKAGE_STO.EMP_I_ID = T_EMPLACEMENT_EMP.EMP_I_ID INNER JOIN
                      T_LIEU_LIE ON T_EMPLACEMENT_EMP.LIE_I_ID = T_LIEU_LIE.LIE_I_ID INNER JOIN
                      T_BOUTEILLE_BTL ON T_STOCKAGE_STO.BTL_I_ID = T_BOUTEILLE_BTL.BTL_I_ID INNER JOIN
                      T_CHATEAU_CHT ON T_CHATEAU_CHT.CHT_I_ID = T_BOUTEILLE_BTL.CHT_I_ID
WHERE T_LIEU_LIE.LIE_I_ID = @ID
GROUP BY T_EMPLACEMENT_EMP.EMP_I_ID, T_EMPLACEMENT_EMP.LIE_I_ID, T_BOUTEILLE_BTL.BTL_I_ID, T_LIEU_LIE.LIE_I_CAPA, T_EMPLACEMENT_EMP.EMP_I_POSH, T_EMPLACEMENT_EMP.EMP_I_POSV, T_CHATEAU_CHT.CHT_S_CHATEAU, T_BOUTEILLE_BTL.BTL_I_MILLESIME, T_STOCKAGE_STO.EMP_I_ID
GO
