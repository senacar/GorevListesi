USE [reminder]
GO
/****** Object:  StoredProcedure [dbo].[sp_search]    Script Date: 2/28/2023 4:15:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_search]
(
@search nvarchar(200)
)
as
begin
select * from Gorev where GorevID like '%' + @search + '%'
or GorevSahibi like '%' + @search + '%' or gorev like '%' + @search + '%' 
or musteri like '%' + @search + '%' or PlanlananBitis like '%' + @search + '%' 
or GercekBitis like '%' + @search + '%' 
end
GO
