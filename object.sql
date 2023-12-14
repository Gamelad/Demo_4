create view v_Product_1
as
select Products.ProductID,Products.ProductName,Products.ProductDesc,Products.ProductCost,Products.ProductDiscount,
Products.ProductCount,Products.ProductImage,Manufacturers.ManufacturerTitle,Providers.ProviderTitle,Categories.CategoryTitle
from Products inner join Manufacturers on Products.ManufacturerID = Manufacturers.ManufacturerID
inner join Providers on Products.ProviderID = Providers.ProviderID
inner join Categories on Products.CategoryID = Categories.CategoryID
select*from v_Product_1

alter proc sp_Load_2
@filter nvarchar(255),@sort nvarchar(255),@search nvarchar(max)
as
begin
	select*from v_Product_1
	where (@filter = 'Без скидки')
	or (@filter != '15%-55%' or ProductDiscount between 15 and 55.5)
	and (@filter != '55%-89%' or ProductDiscount between 15 and 89)
	and (ProductName like '%'+@search+'%'
	or ProductDesc like '%'+@search+'%')
	order by 
	case when @sort = '1' then ProductCost else null
	end asc,
	case when @sort = '2' then ProductCost else null
	end desc;
end;
execute sp_Load_2 '15%-55%','',''

select*from Users