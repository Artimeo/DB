use autoparts;
select * from parts where parts.price >= 5000;
select * from pricehistory order by price_date;
select STDDEV_SAMP(price) from parts;

select deals.article, parts.title, deals.deal_date, deals.deal_parts_count
from deals join parts on parts.article = deals.article order by deals.deal_date;

select parts.article, parts.title, parts.manufacturer, parts.price, providers.title, providers.phone from parts, providers, bridge_providers_parts
where parts.article = bridge_providers_parts.article and providers.title = bridge_providers_parts.title
order by providers.title, parts.article;