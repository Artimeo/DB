go
create view storehouse as select distinct
deals.id as 'id',
parts.article as '���', 
parts.title as '��������', 
parts.price as '����',
deals.parts_count as '����������', 
parts.manufacturer as '�������������',
(select distinct price from priceHistory where 
	priceHistory.price_id = (select max(price_id) from priceHistory where priceHistory.parts_article = bridge_providers_parts.parts_article) ) 
	as '���� �������',
deals.deal_date as '���� �������', 
providers.title as '���������' 
from parts, providers, deals, bridge_providers_parts, priceHistory
where deals.bridge_id = bridge_providers_parts.id
 and parts.article = bridge_providers_parts.parts_article
 and providers.title = bridge_providers_parts.providers_title
 and priceHistory.parts_article = bridge_providers_parts.parts_article;

 go
 alter view priceview as select top 1000
 priceHistory.price_id as 'id',
 parts.article as '��� ������',
 parts.title as '��������',
 parts.price as '������� ����',
 priceHistory.price as '������ ����',
 priceHistory.price_date as '����������� ��'
 from priceHistory
	right join parts
	on parts.article = priceHistory.parts_article
	/*where parts.price <> priceHistory.price*/
	order by priceHistory.price_date desc, parts.article, priceHistory.price_id
