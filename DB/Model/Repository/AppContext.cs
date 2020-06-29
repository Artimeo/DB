using DB.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DB.Model.Repository
{
    public class AppContext : DbContext
    {
        public AppContext()
        {
            Database.EnsureCreated();
        }

        public DbSet<Provider> Providers { get; set; }
        public DbSet<Part> Parts { get; set; }
        public DbSet<ProviderPart> ProvidersParts { get; set; }
        public DbSet<Deal> Deals { get; set; }
        public DbSet<PriceHistory> PriceHistories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AutoParts;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            List<Part> parts = new List<Part>
            {
                new Part { Id = 1 , Title = "Рулевая рейка", Manufacturer = "Nissan Almera N16", Price = 12000 },
                new Part { Id = 2 , Title = "Пепельница", Manufacturer = "ВАЗ 2114", Price = 700 },
                new Part { Id = 3 , Title = "Салонный фильтр", Manufacturer = "Toyota Camry 40", Price = 1300 },
                new Part { Id = 4 , Title = "Свечи зажигания", Manufacturer = "NGK", Price = 100 },
                new Part { Id = 5 , Title = "Ремень привода водяной помпы", Manufacturer = "Opel Astra", Price = 950 },
                new Part { Id = 6 , Title = "Блок ABS", Manufacturer = "Honda HR-V", Price = 8000 },
                new Part { Id = 7 , Title = "Аккумулятор", Manufacturer = "ExtraStar", Price = 3000 },
                new Part { Id = 8 , Title = "Рулевая тяга", Manufacturer = "Volkswagen Jetta", Price = 1420 },
                new Part { Id = 9 , Title = "Тормозные колодки", Manufacturer = "Kia Rio", Price = 2467 },
                new Part { Id = 10, Title = "Фильтр топливный", Manufacturer = "ВАЗ Kalina", Price = 1140 },
                new Part { Id = 11, Title = "Радиатор двигателя", Manufacturer = "ВАЗ Granta", Price = 7200 },
                new Part { Id = 12, Title = "Стартер", Manufacturer = "Mitsubishi Pajero", Price = 3600 },
                new Part { Id = 13, Title = "Диск сцепления", Manufacturer = "Mitsubishi Lancer X", Price = 1600 },
                new Part { Id = 14, Title = "ШРУС", Manufacturer = "Skoda Oktavia", Price = 4120 },
                new Part { Id = 15, Title = "Катушка зажигания", Manufacturer = "Nissan Primera G11", Price = 1800 },
                new Part { Id = 16, Title = "Тросс стояночного тормоза", Manufacturer = "Volkswagen Passat", Price = 1400 },
                new Part { Id = 17, Title = "Подшипник ступицы", Manufacturer = "ВАЗ Kalina", Price = 1873 },
                new Part { Id = 18, Title = "Интеркулер", Manufacturer = "Subaru Forester", Price = 9980 },
                new Part { Id = 19, Title = "Рычаг подвески", Manufacturer = "Honda HR-V", Price = 3710 },
                new Part { Id = 20, Title = "Сайлентблок", Manufacturer = "LADA Vesta", Price = 1300 },
                new Part { Id = 21, Title = "Фильтр салона", Manufacturer = "BMW e53", Price = 1890 },
                new Part { Id = 22, Title = "Ролик ремня ГРМ", Manufacturer = "Volkswagen Passat", Price = 2800 }
            };
            modelBuilder.Entity<Part>().HasData(parts.ToArray());

            var providers = new List<Provider>
            {
                new Provider { Id = 1 , Title = "Автоток", Address = "ул. Литвинова 20а", Phone = "+78412296880" },
                new Provider { Id = 2 , Title = "Интер-авто" , Address = "ул. Кулакова 14б" ,Phone = "+78412540304" },
                new Provider { Id = 3 , Title = "Vag.Direction", Address = "ул. Красная 29" ,Phone = "+78412625323" },
                new Provider { Id = 4 , Title = "Автостоп", Address = "ул. Измайлова 32" , Phone = "+78412625323" },
                new Provider { Id = 5 , Title = "Магазин-разборка 58", Address = "ул. Кураева 49" ,Phone = "+78412684086" },
                new Provider { Id = 6 , Title = "Запчастье" , Address = "ул. Ставского 4", Phone = "+78412224610" }
            };
            modelBuilder.Entity<Provider>().HasData(providers.ToArray());


            var providersParts = new List<ProviderPart>
            {
                new ProviderPart { Id = 1 , ProviderId = 6, PartId = 6  },
                new ProviderPart { Id = 2 , ProviderId = 6, PartId = 5  },
                new ProviderPart { Id = 3 , ProviderId = 6, PartId = 12 },
                new ProviderPart { Id = 4 , ProviderId = 6, PartId = 13 },
                new ProviderPart { Id = 5 , ProviderId = 6, PartId = 14 },
                new ProviderPart { Id = 6 , ProviderId = 6, PartId = 17 },
                new ProviderPart { Id = 7 , ProviderId = 6, PartId = 18 },
                new ProviderPart { Id = 8 , ProviderId = 6, PartId = 20 },
                new ProviderPart { Id = 9 , ProviderId = 6, PartId = 21 },
                new ProviderPart { Id = 10, ProviderId = 6, PartId = 22 },
                new ProviderPart { Id = 11, ProviderId = 1, PartId = 4  },
                new ProviderPart { Id = 12, ProviderId = 1, PartId = 15 },
                new ProviderPart { Id = 13, ProviderId = 1, PartId = 7  },
                new ProviderPart { Id = 14, ProviderId = 3, PartId = 8  },
                new ProviderPart { Id = 15, ProviderId = 3, PartId = 16 },
                new ProviderPart { Id = 16, ProviderId = 3, PartId = 22 },
                new ProviderPart { Id = 17, ProviderId = 4, PartId = 1  },
                new ProviderPart { Id = 18, ProviderId = 4, PartId = 3  },
                new ProviderPart { Id = 19, ProviderId = 4, PartId = 9  },
                new ProviderPart { Id = 20, ProviderId = 4, PartId = 10 },
                new ProviderPart { Id = 21, ProviderId = 4, PartId = 15 },
                new ProviderPart { Id = 22, ProviderId = 4, PartId = 20 },
                new ProviderPart { Id = 23, ProviderId = 5, PartId = 2  },
                new ProviderPart { Id = 24, ProviderId = 5, PartId = 11 },
                new ProviderPart { Id = 25, ProviderId = 5, PartId = 12 },
                new ProviderPart { Id = 26, ProviderId = 5, PartId = 14 },
                new ProviderPart { Id = 27, ProviderId = 5, PartId = 16 },
                new ProviderPart { Id = 28, ProviderId = 5, PartId = 18 },
                new ProviderPart { Id = 29, ProviderId = 5, PartId = 22 }
            };
            modelBuilder.Entity<ProviderPart>().HasData(providersParts.ToArray());

            var deals = new List<Deal>
            {
                new Deal { Id = 1 , Date = DateTime.Parse("2018.08.15"), PartId = 2 , Count = 1 },
                new Deal { Id = 2 , Date = DateTime.Parse("2018.08.19"), PartId = 2 , Count = 4 },
                new Deal { Id = 3 , Date = DateTime.Parse("2018.08.19"), PartId = 1 , Count = 2 },
                new Deal { Id = 4 , Date = DateTime.Parse("2018.08.21"), PartId = 1 , Count = 3 },
                new Deal { Id = 5 , Date = DateTime.Parse("2018.09.06"), PartId = 1 , Count = 1 },
                new Deal { Id = 6 , Date = DateTime.Parse("2018.08.26"), PartId = 1 , Count = 1 },
                new Deal { Id = 7 , Date = DateTime.Parse("2018.08.26"), PartId = 3 , Count = 2 },
                new Deal { Id = 8 , Date = DateTime.Parse("2018.08.30"), PartId = 3 , Count = 5 },
                new Deal { Id = 9 , Date = DateTime.Parse("2018.09.02"), PartId = 4 , Count = 2 },
                new Deal { Id = 10, Date = DateTime.Parse("2018.09.03"), PartId = 5 , Count = 7 },
                new Deal { Id = 11, Date = DateTime.Parse("2018.09.07"), PartId = 6 , Count = 4 },
                new Deal { Id = 12, Date = DateTime.Parse("2018.09.08"), PartId = 6 , Count = 1 },
                new Deal { Id = 13, Date = DateTime.Parse("2018.09.08"), PartId = 7 , Count = 3 },
                new Deal { Id = 14, Date = DateTime.Parse("2018.09.09"), PartId = 7 , Count = 2 },
                new Deal { Id = 15, Date = DateTime.Parse("2018.09.11"), PartId = 8 , Count = 6 },
                new Deal { Id = 16, Date = DateTime.Parse("2018.08.23"), PartId = 8 , Count = 1 },
                new Deal { Id = 17, Date = DateTime.Parse("2018.08.27"), PartId = 8 , Count = 2 },
                new Deal { Id = 18, Date = DateTime.Parse("2018.08.15"), PartId = 9 , Count = 1 },
                new Deal { Id = 19, Date = DateTime.Parse("2018.08.19"), PartId = 9 , Count = 4 },
                new Deal { Id = 20, Date = DateTime.Parse("2018.08.19"), PartId = 10, Count = 2 },
                new Deal { Id = 21, Date = DateTime.Parse("2018.08.21"), PartId = 10, Count = 3 },
                new Deal { Id = 22, Date = DateTime.Parse("2018.09.06"), PartId = 10, Count = 1 },
                new Deal { Id = 23, Date = DateTime.Parse("2018.09.26"), PartId = 10, Count = 1 },
                new Deal { Id = 24, Date = DateTime.Parse("2018.09.26"), PartId = 11, Count = 2 },
                new Deal { Id = 25, Date = DateTime.Parse("2018.08.30"), PartId = 12, Count = 5 },
                new Deal { Id = 26, Date = DateTime.Parse("2018.09.02"), PartId = 13, Count = 2 },
                new Deal { Id = 27, Date = DateTime.Parse("2018.08.09"), PartId = 13, Count = 2 },
                new Deal { Id = 28, Date = DateTime.Parse("2018.08.03"), PartId = 14, Count = 7 },
                new Deal { Id = 29, Date = DateTime.Parse("2018.08.28"), PartId = 15, Count = 4 },
                new Deal { Id = 30, Date = DateTime.Parse("2018.09.18"), PartId = 15, Count = 1 },
                new Deal { Id = 31, Date = DateTime.Parse("2018.08.17"), PartId = 16, Count = 3 },
                new Deal { Id = 32, Date = DateTime.Parse("2018.09.25"), PartId = 16, Count = 2 },
                new Deal { Id = 33, Date = DateTime.Parse("2018.08.13"), PartId = 17, Count = 6 },
                new Deal { Id = 34, Date = DateTime.Parse("2018.09.24"), PartId = 17, Count = 1 },
                new Deal { Id = 35, Date = DateTime.Parse("2018.09.26"), PartId = 17, Count = 2 },
                new Deal { Id = 36, Date = DateTime.Parse("2018.09.17"), PartId = 18, Count = 6 },
                new Deal { Id = 37, Date = DateTime.Parse("2018.08.14"), PartId = 18, Count = 1 },
                new Deal { Id = 38, Date = DateTime.Parse("2018.08.20"), PartId = 18, Count = 2 },
                new Deal { Id = 39, Date = DateTime.Parse("2018.09.12"), PartId = 19, Count = 1 },
                new Deal { Id = 40, Date = DateTime.Parse("2018.09.11"), PartId = 19, Count = 4 },
                new Deal { Id = 41, Date = DateTime.Parse("2018.09.13"), PartId = 20, Count = 2 },
                new Deal { Id = 42, Date = DateTime.Parse("2018.08.29"), PartId = 20, Count = 3 },
                new Deal { Id = 43, Date = DateTime.Parse("2018.09.25"), PartId = 20, Count = 1 },
                new Deal { Id = 44, Date = DateTime.Parse("2018.08.26"), PartId = 20, Count = 1 },
                new Deal { Id = 45, Date = DateTime.Parse("2018.09.26"), PartId = 21, Count = 2 },
                new Deal { Id = 46, Date = DateTime.Parse("2018.08.17"), PartId = 22, Count = 5 },
                new Deal { Id = 47, Date = DateTime.Parse("2018.09.17"), PartId = 22, Count = 2 }
            };
            modelBuilder.Entity<Deal>().HasData(deals.ToArray());

            base.OnModelCreating(modelBuilder);
        }
    }
    
}
