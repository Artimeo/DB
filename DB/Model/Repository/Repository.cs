using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DB.Model.Repository
{
    public class Repository
    {
        private AppContext context = new AppContext();
        public static Repository Current
        {
            get { return new Repository(); }
        }

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

        public class StorehouseItem {
            public int Id { get; set; }               //id
            public int PartId { get; set; }           //код детали
            public string Title { get; set; }         //название
            public int Price { get; set; }            //цена
            public int Count { get; set; }            //количество
            public string Manufacturer { get; set; }  //производитель
            public int OriginalPrice { get; set; }    //цена закупки
            public DateTime Date { get; set; }        //дата закупки
            public string ProviderTitle { get; set; } //поставщик

            public override string ToString()
            {
                return String.Format("Id: {0},\n" +
                                         "код детали: {1},\n" +
                                         "название: {2},\n" +
                                         "цена: {3},\n" +
                                         "количество: {4}, \n" +
                                         "производитель: {5}\n" +
                                         "цена закупки: {6}\n" +
                                         "дата закупки: {7}\n" +
                                         "поставщик: {8}",

                                         Id, PartId, Title, Price, Count, Manufacturer, OriginalPrice, Date, ProviderTitle);
            }
        }

        public List<StorehouseItem> Storehouse()
        {

            var storehouseItems = (from deal in context.Deals
                                  join providerPart in context.ProvidersParts on deal.ProviderPartId equals providerPart.Id
                                  join part in context.Parts on providerPart.PartId equals part.Id
                                  join provider in context.Providers on providerPart.ProviderId equals provider.Id
                                  let price = context.PriceHistories.OrderByDescending(p => p.Id).Where(p => p.PartId == part.Id).Select(p => p.Price).SingleOrDefault()
                                  //where ...
                                  select new StorehouseItem
                                  {
                                      Id = deal.Id,
                                      PartId = part.Id,
                                      Title = part.Title,
                                      Price = part.Price,
                                      Count = deal.Count,
                                      Manufacturer = part.Manufacturer,
                                      OriginalPrice = price,
                                      Date = deal.Date,
                                      ProviderTitle = provider.Title
                                  }).OrderBy(item => item.Id);
            var list = storehouseItems.ToList();
            return list;
        }
    }
}
