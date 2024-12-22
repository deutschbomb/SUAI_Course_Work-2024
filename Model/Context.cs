using Microsoft.EntityFrameworkCore;

namespace App
{
    public class Context : DbContext
    {
        /// <summary>
        /// Наборы данных
        /// </summary>
        public DbSet<Specialty> Specialties { get; set; } = null!;
        public DbSet<Employee> Employees { get; set; } = null!;
        
        public DbSet<Owner> Owners { get; set; } = null!;
        public DbSet<Car> Cars { get; set; } = null!;

        public DbSet<Request> Requests { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<Work> Works { get; set; } = null!;

        public DbSet<Supplier> Suppliers { get; set; } = null!;
        public DbSet<Supply> Supplies { get; set; } = null!;
        public DbSet<Position> Positions { get; set; } = null!;
        public DbSet<Part> Parts { get; set; } = null!;
        public DbSet<Accounting> StorageParts { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"Server=DEUTSCHBOMB-PC;Database=AutoServiceDB;Integrated Security=True;Encrypt=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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

            modelBuilder.Entity<Supplier>()
                .HasMany(c => c.Parts)
                .WithMany(s => s.Suppliers)
                .UsingEntity(j => j.ToTable("Nomenclature"));

            modelBuilder.Entity<Accounting>().HasKey(a => a.PartId);

            modelBuilder.Entity<Work>()
                .HasMany(w => w.Parts)
                .WithMany(p => p.Works)
                .UsingEntity<Order>(
                    j => j
                        .HasOne(pt => pt.Part)
                        .WithMany(t => t.Orders)
                        .HasForeignKey(pt => pt.PartId),
                    j => j
                        .HasOne(pt => pt.Work)
                        .WithMany(t => t.Orders)
                        .HasForeignKey(pt => pt.WorkId),
                    j =>
                    {
                        j.ToTable("Orders");
                    });
            modelBuilder.Entity<Work>()
                .HasMany(w => w.Employees)
                .WithMany(e => e.Works)
                .UsingEntity<Order>(
                    j => j
                        .HasOne(pt => pt.Employee)
                        .WithMany(t => t.Orders)
                        .HasForeignKey(pt => pt.EmployeeId),
                    j => j
                        .HasOne(pt => pt.Work)
                        .WithMany(t => t.Orders)
                        .HasForeignKey(pt => pt.WorkId),
                    j =>
                    {
                        j.ToTable("Orders");
                    });
        }
    }
}
