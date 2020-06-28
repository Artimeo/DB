go
create view storehouse as select distinct
deals.id as 'id',
parts.article as 'Код', 
parts.title as 'Название', 
parts.price as 'Цена',
deals.parts_count as 'Количество', 
parts.manufacturer as 'Производитель',
(select distinct price from priceHistory where 
	priceHistory.price_id = (select max(price_id) from priceHistory where priceHistory.parts_article = bridge_providers_parts.parts_article) ) 
	as 'Цена закупки',
deals.deal_date as 'Дата закупки', 
providers.title as 'Поставщик' 
from parts, providers, deals, bridge_providers_parts, priceHistory
where deals.bridge_id = bridge_providers_parts.id
 and parts.article = bridge_providers_parts.parts_article
 and providers.title = bridge_providers_parts.providers_title
 and priceHistory.parts_article = bridge_providers_parts.parts_article;

 go
 alter view priceview as select top 1000
 priceHistory.price_id as 'id',
 parts.article as 'Код детали',
 parts.title as 'Название',
 parts.price as 'Текущая цена',
 priceHistory.price as 'Старая цена',
 priceHistory.price_date as 'Действовала до'
 from priceHistory
	right join parts
	on parts.article = priceHistory.parts_article
	/*where parts.price <> priceHistory.price*/
	order by priceHistory.price_date desc, parts.article, priceHistory.price_id
