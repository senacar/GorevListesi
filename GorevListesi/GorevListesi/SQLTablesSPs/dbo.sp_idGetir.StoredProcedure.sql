USE [reminder]
GO
/****** Object:  StoredProcedure [dbo].[sp_idGetir]    Script Date: 2/28/2023 4:15:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_idGetir]
(
@GorevSahibi nvarchar(50),
@gorev nvarchar(200),
@musteri nvarchar(50),
@PlanBitis datetime,
@GercekBitis datetime
)
as
begin
select GorevID from Gorev where GorevSahibi=@GorevSahibi and gorev=@gorev and musteri=@musteri and
PlanlananBitis=@PlanBitis and GercekBitis=@GercekBitis
end
GO
