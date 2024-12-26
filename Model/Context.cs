
using EntityFramework.Exceptions.SqlServer;
using Microsoft.EntityFrameworkCore;

namespace App
{
    public class Context : DbContext
    {
        #region Наборы данных
        public DbSet<Specialty> Specialties { get; set; } = null!;
        public DbSet<Employee> Employees { get; set; } = null!;
        
        public DbSet<Owner> Owners { get; set; } = null!;
        public DbSet<Car> Cars { get; set; } = null!;

        public DbSet<Request> Requests { get; set; } = null!;

        public DbSet<Supplier> Suppliers { get; set; } = null!;
        public DbSet<Supply> Supplies { get; set; } = null!;
        public DbSet<Position> Positions { get; set; } = null!;
        public DbSet<Part> Parts { get; set; } = null!;
        public DbSet<Accounting> StorageParts { get; set; } = null!;
        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Подключение к серверу с базой данных
            optionsBuilder
                .UseSqlServer(@"Server=DEUTSCHBOMB-PC;Database=AutoServiceDB;Integrated Security=True;Encrypt=False")
                .UseExceptionProcessor();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Явное определение таблицы с позициями поставок:
            // поставляемые запчасти и их количество
            modelBuilder.Entity<Part>()
                .HasMany(c => c.Supplies)
                .WithMany(s => s.Parts)
                .UsingEntity<Position>(
                    j => j
                        .HasOne(pt => pt.Supply)
                        .WithMany(t => t.Positions)
                        .HasForeignKey(pt => pt.SupplyId),
                    j => j
                        .HasOne(pt => pt.Part)
                        .WithMany(p => p.Positions)
                        .HasForeignKey(pt => pt.PartId),
                    j =>
                    {
                        j.Property(pt => pt.Amount).HasDefaultValue(0);
                        j.HasKey(t => new { t.SupplyId, t.PartId });
                        j.ToTable("Positions");
                    });

            // Явное определение таблицы с номенклатурами поставщиков
            modelBuilder.Entity<Supplier>()
                .HasMany(c => c.Parts)
                .WithMany(s => s.Suppliers)
                .UsingEntity(j => j.ToTable("Nomenclature"));

            modelBuilder.Entity<Accounting>().HasKey(a => a.PartId);

            // Заполнение таблицы основными должностями
            modelBuilder.Entity<Specialty>().HasData(
                new Specialty { SpecialtyId = 1, SpecialtyName = "Менеджер" },
                new Specialty { SpecialtyId = 2, SpecialtyName = "Механик" },
                new Specialty { SpecialtyId = 3, SpecialtyName = "Кладовщик" });

            // Заполнение таблицы запчастями
            modelBuilder.Entity<Part>().HasData(
                new Part { PartId = 1, CatalogueNumber = "1421427908", PartName = "Масляный фильтр" },
                new Part { PartId = 2, CatalogueNumber = "6460920301", PartName = "Топливный фильтр" },
                new Part { PartId = 3, CatalogueNumber = "165460509R", PartName = "Воздушный фильтр" },
                new Part { PartId = 4, CatalogueNumber = "0DJ300027H", PartName = "6-ступенчатая МКП" },
                new Part { PartId = 5, CatalogueNumber = "1K0411105A", PartName = "Пружина амортизатора" },
                new Part { PartId = 6, CatalogueNumber = "1K0413031B", PartName = "Амортизатор" });

            // Заполнение таблицы поставщиками
            modelBuilder.Entity<Supplier>().HasData(
                new Supplier { SupplierId = 1, TaxpayerIdentificationNumber = "6311116633", SupplierName = "VAG" },
                new Supplier { SupplierId = 2, TaxpayerIdentificationNumber = "7728798878", SupplierName = "Bilstein" },
                new Supplier { SupplierId = 3, TaxpayerIdentificationNumber = "7706092944", SupplierName = "Bosch" },
                new Supplier { SupplierId = 4, TaxpayerIdentificationNumber = "7708259331", SupplierName = "Goodwill" });
        }
    }
}
