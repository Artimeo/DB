using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Model.Repository
{
    public class Repository
    {
        private AppContext context = new AppContext();
        public static Repository Current { get; } = new Repository();

        public IEnumerable<Part> Parts { get { return context.Parts; } }
        public IEnumerable<Provider> Providers { get { return context.Providers; } }
        public IEnumerable<Deal> Deals { get { return context.Deals; } }
        public IEnumerable<PriceHistory> PriceHistories { get { return context.PriceHistories; } }

        //create view storehouse as select distinct
        //deals.id as 'id',
        //parts.article as 'Код', 
        //parts.title as 'Название', 
        //parts.price as 'Цена',
        //deals.parts_count as 'Количество', 
        //parts.manufacturer as 'Производитель',
        //(select distinct price from priceHistory where
        //    priceHistory.price_id = (select max(price_id) from priceHistory where priceHistory.parts_article = bridge_providers_parts.parts_article) ) 
	       // as 'Цена закупки',
        //deals.deal_date as 'Дата закупки', 
        //providers.title as 'Поставщик' 
        //from parts, providers, deals, bridge_providers_parts, priceHistory
        //where deals.bridge_id = bridge_providers_parts.id
        // and parts.article = bridge_providers_parts.parts_article
        // and providers.title = bridge_providers_parts.providers_title
        // and priceHistory.parts_article = bridge_providers_parts.parts_article;

        public List<string> Storehouse()
        {
            
            var storehouse = from part in context.Parts 
                             join providerPart in context.ProvidersParts on part.Id equals providerPart.PartId
                             join provider in context.Providers on providerPart.ProviderId equals provider.Id
                             join priceHistory in context.PriceHistories on part.Id equals priceHistory.PartId
                             join deal in context.Deals on part.Id equals deal.PartId
                             select new {deal.Id as "id", part.Id as "Код", }
        }
    }
}
