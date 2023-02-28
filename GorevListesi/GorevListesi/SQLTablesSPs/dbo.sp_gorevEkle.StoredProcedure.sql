USE [reminder]
GO
/****** Object:  StoredProcedure [dbo].[sp_gorevEkle]    Script Date: 2/28/2023 4:15:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_gorevEkle]
(
@GorevSahibi varchar(50),
@gorev varchar(200),
@musteri varchar(70),
@PlanBitis datetime,
@GercekBitis datetime
)
as
begin
insert into Gorev (GorevSahibi, gorev, musteri, PlanlananBitis, GercekBitis)
values(@GorevSahibi,@gorev,@musteri, @PlanBitis, @GercekBitis)
end
GO
