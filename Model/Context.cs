using AutoService.Model.Parts;
using AutoService.Model.Sevice;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService.Model
{
    public class Context : DbContext
    {
        public DbSet<Owner> Owners { get; set; } = null!;
        public DbSet<Car> Cars { get; set; } = null!;
        /*
        public DbSet<Manager> Managers { get; set; } = null!;
        public DbSet<Mechanic> Mechanics { get; set; } = null!;
        public DbSet<Storekeeper> Storekeepers { get; set; } = null!;
        */
        public DbSet<Supplier> Suppliers { get; set; } = null!;
        public DbSet<Supply> Supplies { get; set; } = null!;
        public DbSet<Request> Requests { get; set; } = null!;
        public DbSet<Work> Works { get; set; } = null!;
        public DbSet<Part> Parts { get; set; } = null!;
        public DbSet<Storage> Accounting {  get; set; } = null!;


        //public string DbPath { get; }

        //public Context()
        //{
        //    var folder = Environment.SpecialFolder.LocalApplicationData;
        //    var path = Environment.GetFolderPath(folder);
        //    DbPath = System.IO.Path.Join(path, "AutoService.db");
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DEUTSCHBOMB-PC;Database=AutoServiceDB;UserID=sa");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
