using DB.Model;
using Microsoft.EntityFrameworkCore;
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
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProviderPart>()
                .HasOne<Part>(pp => pp.Part)
                .WithMany(p => p.ProviderParts)
                .HasForeignKey(pp => pp.PartId);

            modelBuilder.Entity<ProviderPart>()
                .HasOne<Provider>(pp => pp.Provider)
                .WithMany(p => p.ProviderParts)
                .HasForeignKey(pp => pp.ProviderId);
            
            List<Part> parts = new List<Part>
            {
                new Part { Title = "Рулевая рейка", Manufacturer = "Nissan Almera N16", Price = 12000 },
                new Part { Title = "Пепельница", Manufacturer = "ВАЗ 2114", Price = 700 },
                new Part { Title = "Салонный фильтр", Manufacturer = "Toyota Camry 40", Price = 1300 },
                new Part { Title = "Свечи зажигания", Manufacturer = "NGK", Price = 100 },
                new Part { Title = "Ремень привода водяной помпы", Manufacturer = "Opel Astra", Price = 950 },
                new Part { Title = "Блок ABS", Manufacturer = "Honda HR-V", Price = 8000 },
                new Part { Title = "Аккумулятор", Manufacturer = "ExtraStar", Price = 3000 },
                new Part { Title = "Рулевая тяга", Manufacturer = "Volkswagen Jetta", Price = 1420 },
                new Part { Title = "Тормозные колодки", Manufacturer = "Kia Rio", Price = 2467 },
                new Part { Title = "Фильтр топливный", Manufacturer = "ВАЗ Kalina", Price = 1140 },
                new Part { Title = "Радиатор двигателя", Manufacturer = "ВАЗ Granta", Price = 7200 },
                new Part { Title = "Стартер", Manufacturer = "Mitsubishi Pajero", Price = 3600 },
                new Part { Title = "Диск сцепления", Manufacturer = "Mitsubishi Lancer X", Price = 1600 },
                new Part { Title = "ШРУС", Manufacturer = "Skoda Oktavia", Price = 4120 },
                new Part { Title = "Катушка зажигания", Manufacturer = "Nissan Primera G11", Price = 1800 },
                new Part { Title = "Тросс стояночного тормоза", Manufacturer = "Volkswagen Passat", Price = 1400 },
                new Part { Title = "Подшипник ступицы", Manufacturer = "ВАЗ Kalina", Price = 1873 },
                new Part { Title = "Интеркулер", Manufacturer = "Subaru Forester", Price = 9980 },
                new Part { Title = "Рычаг подвески", Manufacturer = "Honda HR-V", Price = 3710 },
                new Part { Title = "Сайлентблок", Manufacturer = "LADA Vesta", Price = 1300 },
                new Part { Title = "Фильтр салона", Manufacturer = "BMW e53", Price = 1890 },
                new Part { Title = "Ролик ремня ГРМ", Manufacturer = "Volkswagen Passat", Price = 2800 }
            };
            modelBuilder.Entity<Part>().HasData(parts);

            var providers = new List<Provider>
            {
                new Provider {Title = "Автоток", Address = "ул. Литвинова 20а", Phone = "+78412296880" },
                new Provider {Title = "Интер-авто" , Address = "ул. Кулакова 14б" ,Phone = "+78412540304" },
                new Provider {Title = "Vag.Direction", Address = "ул. Красная 29" ,Phone = "+78412625323" },
                new Provider {Title = "Автостоп", Address = "ул. Измайлова 32" , Phone = "+78412625323" },
                new Provider {Title = "Магазин-разборка 58", Address = "ул. Кураева 49" ,Phone = "+78412684086" },
                new Provider {Title = "Запчастье" , Address = "ул. Ставского 4", Phone = "+78412224610" }
            };

            modelBuilder.Entity<Provider>().HasData(providers);


            var providersParts = new List<ProviderPart>
            {
                new ProviderPart { Provider = providers[6+1], Part = parts[6 +1]  },
                new ProviderPart { Provider = providers[6+1], Part = parts[5 +1] },
                new ProviderPart { Provider = providers[6+1], Part = parts[12+1] },
                new ProviderPart { Provider = providers[6+1], Part = parts[13+1] },
                new ProviderPart { Provider = providers[6+1], Part = parts[14+1] },
                new ProviderPart { Provider = providers[6+1], Part = parts[17+1] },
                new ProviderPart { Provider = providers[6+1], Part = parts[18+1] },
                new ProviderPart { Provider = providers[6+1], Part = parts[20+1] },
                new ProviderPart { Provider = providers[6+1], Part = parts[21+1] },
                new ProviderPart { Provider = providers[6+1], Part = parts[22+1] },
                new ProviderPart { Provider = providers[1+1], Part = parts[4 +1] },
                new ProviderPart { Provider = providers[1+1], Part = parts[15+1] },
                new ProviderPart { Provider = providers[1+1], Part = parts[7 +1] },
                new ProviderPart { Provider = providers[3+1], Part = parts[8 +1] },
                new ProviderPart { Provider = providers[3+1], Part = parts[16+1] },
                new ProviderPart { Provider = providers[3+1], Part = parts[22+1] },
                new ProviderPart { Provider = providers[4+1], Part = parts[1 +1] },
                new ProviderPart { Provider = providers[4+1], Part = parts[3 +1] },
                new ProviderPart { Provider = providers[4+1], Part = parts[9 +1] },
                new ProviderPart { Provider = providers[4+1], Part = parts[10+1] },
                new ProviderPart { Provider = providers[4+1], Part = parts[15+1] },
                new ProviderPart { Provider = providers[4+1], Part = parts[20+1] },
                new ProviderPart { Provider = providers[5+1], Part = parts[2 +1] },
                new ProviderPart { Provider = providers[5+1], Part = parts[11+1] },
                new ProviderPart { Provider = providers[5+1], Part = parts[12+1] },
                new ProviderPart { Provider = providers[5+1], Part = parts[14+1] },
                new ProviderPart { Provider = providers[5+1], Part = parts[16+1] },
                new ProviderPart { Provider = providers[5+1], Part = parts[18+1] },
                new ProviderPart { Provider = providers[5+1], Part = parts[22+1] }
            };
            modelBuilder.Entity<ProviderPart>().HasData(providersParts);

            var deals = new List<Deal>
            {
                new Deal{ Date = DateTime.Parse("2018.08.15"), Part = parts[2 +1], Count = 1 },
                new Deal {Date = DateTime.Parse("2018.08.19"), Part = parts[2 +1], Count = 4 },
                new Deal {Date = DateTime.Parse("2018.08.19"), Part = parts[1 +1], Count = 2 },
                new Deal {Date = DateTime.Parse("2018.08.21"), Part = parts[1 +1], Count = 3 },
                new Deal {Date = DateTime.Parse("2018.09.06"), Part = parts[1 +1], Count = 1 },
                new Deal {Date = DateTime.Parse("2018.08.26"), Part = parts[1 +1], Count = 1 },
                new Deal {Date = DateTime.Parse("2018.08.26"), Part = parts[3 +1], Count = 2 },
                new Deal {Date = DateTime.Parse("2018.08.30"), Part = parts[3 +1], Count = 5 },
                new Deal {Date = DateTime.Parse("2018.09.02"), Part = parts[4 +1], Count = 2 },
                new Deal {Date = DateTime.Parse("2018.09.03"), Part = parts[5 +1], Count = 7 },
                new Deal {Date = DateTime.Parse("2018.09.07"), Part = parts[6 +1], Count = 4 },
                new Deal {Date = DateTime.Parse("2018.09.08"), Part = parts[6 +1], Count = 1 },
                new Deal {Date = DateTime.Parse("2018.09.08"), Part = parts[7 +1], Count = 3 },
                new Deal {Date = DateTime.Parse("2018.09.09"), Part = parts[7 +1], Count = 2 },
                new Deal {Date = DateTime.Parse("2018.09.11"), Part = parts[8 +1], Count = 6 },
                new Deal {Date = DateTime.Parse("2018.08.23"), Part = parts[8 +1], Count = 1 },
                new Deal {Date = DateTime.Parse("2018.08.27"), Part = parts[8 +1], Count = 2 },
                new Deal {Date = DateTime.Parse("2018.08.15"), Part = parts[9 +1], Count = 1 },
                new Deal {Date = DateTime.Parse("2018.08.19"), Part = parts[9 +1], Count = 4 },
                new Deal {Date = DateTime.Parse("2018.08.19"), Part = parts[10+1], Count = 2 },
                new Deal {Date = DateTime.Parse("2018.08.21"), Part = parts[10+1], Count = 3 },
                new Deal {Date = DateTime.Parse("2018.09.06"), Part = parts[10+1], Count = 1 },
                new Deal {Date = DateTime.Parse("2018.09.26"), Part = parts[10+1], Count = 1 },
                new Deal {Date = DateTime.Parse("2018.09.26"), Part = parts[11+1], Count = 2 },
                new Deal {Date = DateTime.Parse("2018.08.30"), Part = parts[12+1], Count = 5 },
                new Deal {Date = DateTime.Parse("2018.09.02"), Part = parts[13+1], Count = 2 },
                new Deal {Date = DateTime.Parse("2018.08.09"), Part = parts[13+1], Count = 2 },
                new Deal {Date = DateTime.Parse("2018.08.03"), Part = parts[14+1], Count = 7 },
                new Deal {Date = DateTime.Parse("2018.08.28"), Part = parts[15+1], Count = 4 },
                new Deal {Date = DateTime.Parse("2018.09.18"), Part = parts[15+1], Count = 1 },
                new Deal {Date = DateTime.Parse("2018.08.17"), Part = parts[16+1], Count = 3 },
                new Deal {Date = DateTime.Parse("2018.09.25"), Part = parts[16+1], Count = 2 },
                new Deal {Date = DateTime.Parse("2018.08.13"), Part = parts[17+1], Count = 6 },
                new Deal {Date = DateTime.Parse("2018.09.24"), Part = parts[17+1], Count = 1 },
                new Deal {Date = DateTime.Parse("2018.09.26"), Part = parts[17+1], Count = 2 },
                new Deal {Date = DateTime.Parse("2018.09.17"), Part = parts[18+1], Count = 6 },
                new Deal {Date = DateTime.Parse("2018.08.14"), Part = parts[18+1], Count = 1 },
                new Deal {Date = DateTime.Parse("2018.08.20"), Part = parts[18+1], Count = 2 },
                new Deal {Date = DateTime.Parse("2018.09.12"), Part = parts[19+1], Count = 1 },
                new Deal {Date = DateTime.Parse("2018.09.11"), Part = parts[19+1], Count = 4 },
                new Deal {Date = DateTime.Parse("2018.09.13"), Part = parts[20+1], Count = 2 },
                new Deal {Date = DateTime.Parse("2018.08.29"), Part = parts[20+1], Count = 3 },
                new Deal {Date = DateTime.Parse("2018.09.25"), Part = parts[20+1], Count = 1 },
                new Deal {Date = DateTime.Parse("2018.08.26"), Part = parts[20+1], Count = 1 },
                new Deal {Date = DateTime.Parse("2018.09.26"), Part = parts[21+1], Count = 2 },
                new Deal {Date = DateTime.Parse("2018.08.17"), Part = parts[22+1], Count = 5 },
                new Deal {Date = DateTime.Parse("2018.09.17"), Part = parts[22+1], Count = 2 }
            };
            modelBuilder.Entity<Deal>().HasData(deals);
        }
    }
    
}
