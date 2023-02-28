USE [reminder]
GO
/****** Object:  StoredProcedure [dbo].[gorevGuncelle_sp]    Script Date: 2/28/2023 4:15:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[gorevGuncelle_sp]
(
@id int,
@GorevSahibi nvarchar(50),
@gorev nvarchar(200),
@musteri nvarchar(70),
@PlanBitis datetime,
@GercekBitis datetime
)
as
begin
update Gorev set GorevSahibi=@GorevSahibi, gorev=@gorev, musteri=@musteri,
PlanlananBitis=@PlanBitis, GercekBitis=	@GercekBitis where GorevID=@id
end
GO
