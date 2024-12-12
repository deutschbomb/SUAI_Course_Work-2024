using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService.Model.Parts
{
    // Класс поставщика запчастей
    public class Supplier
    {
        public int Id { get; set; } // PrimaryKey
        public string? TaxpayerIdentificationNumber { get; set; }
        public string? SupplierName { get; set; }

        // Навигационные свойства
        public virtual List<Part> Parts { get; set; } // ссылка на поставляемые запчасти

        public Supplier()
        {
            Parts = new List<Part>();
        }
    }
    // Класс поставки запчастей
    public class Supply
    {
        public int Id { get; set; }    // PrimaryKey
        public DateTime DateOfPost { get; set; }
        public bool Delivered { get; set; }
        public DateTime DateOfDelivery { get; set; }
    }

    /*Класс позиций поставок с количеством запчастей
    public class SupplyAmount
    {
        public int Amount { get; set; }

        // ForeignKeys - навигационные свойства
        public virtual List<Supply> Supplies { get; set; } // ссылка на поставки
        public virtual List<Part> Parts { get; set; } // ссылка на поставляемые запчасти
    }*/
}
