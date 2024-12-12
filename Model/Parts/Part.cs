using AutoService.Model.Sevice;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService.Model.Parts
{
    // Класс запчасти
    public class Part
    {
        public int Id { get; set; } // PrimaryKey
        public string? CatalogueNumber { get; set; }
        public string? PartName { get; set; }

        // Навигационные свойства
        public virtual List<Supplier> Suppliers { get; set; } // ссылка на поставщиков запчасти

        // Ссылка на запчасть на складе
        public virtual Storage? Storage { get; set; }

        // Ссылка на заказ-наряд
        public virtual Order? Order { get; set; }

        //public virtual SupplyAmount? SupplyAmount { get; set; }

        public Part()
        {
            Suppliers = new List<Supplier>();
        }
    }

    // Класс склада запчастей
    public class Storage
    {
        public int Balance { get; set; }
        public decimal PartPrice { get; set; }

        // ForeignKeys - навигационные свойства
        public virtual Part? Part { get; set; } // ссылка на запчасть
        public int PartID { get; set; }
    }
}
