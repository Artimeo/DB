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

        public class PartItem
        {
            public string Title { get; set; }
            public int Id { get; set; }
            public string Manufacturer { get; set; }
            public int Price { get; set; }
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

            return storehouseItems.ToList();
        }

        public class ProviderItem
        {
            public string Title { get; set; }
            public string Address { get; set; }
            public string Phone { get; set; }
        }

        public List<PartItem> GetParts()
        {
            var query = from part in Parts
                   select new PartItem
                   {
                       Title = part.Title,
                       Id = part.Id,
                       Manufacturer = part.Manufacturer,
                       Price = part.Price
                   };
            return query.ToList();
        }

        public List<ProviderItem> GetProviders()
        {
            var query = from provider in Providers
                   select new ProviderItem
                   {
                       Title = provider.Title,
                       Address = provider.Address,
                       Phone = provider.Phone
                    };
            return query.ToList();
        }

        public class PriceHistoryItem
        {
            public int Id { get; set; }
            public int PartId { get; set; }
            public string Title { get; set; }
            public int CurrentPrice { get; set; }
            public int OldPrice { get; set; }
            public DateTime ActualBefore { get; set; }
        }

        public List<PriceHistoryItem> GetPriceHistories()
        {
            var query = from priceHistory in PriceHistories
                        select new PriceHistoryItem
                        {
                            Id = priceHistory.Id,
                            PartId = priceHistory.PartId,
                            Title = priceHistory.Part.Title,
                            CurrentPrice = priceHistory.Part.Price,
                            OldPrice = priceHistory.Price,
                            ActualBefore = priceHistory.Date
                        };
            return query.ToList();
        }
    }
}
