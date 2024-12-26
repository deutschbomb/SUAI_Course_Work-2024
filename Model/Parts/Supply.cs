
namespace App
{
    // Класс поставщика запчастей
    public class Supplier
    {
        public int SupplierId { get; set; } // PrimaryKey
        public string? TaxpayerIdentificationNumber { get; set; }
        public string? SupplierName { get; set; }
        public string GetSupplier
        {
            get
            {
                if (this.SupplierName is not null)
                    return this.TaxpayerIdentificationNumber + ": " + this.SupplierName;
                return this.TaxpayerIdentificationNumber;
            }
        }

        // Навигационные свойства
        public virtual List<Supply> Supplies { get; set; } // осуществляемые поставки
        /*
         * M:M - номенклатура
         */
        public virtual List<Part> Parts { get; set; } // поставляемые запчасти

        public override string ToString()
        {
            return this.TaxpayerIdentificationNumber;
        }

        public Supplier()
        {
            this.Supplies = new List<Supply>();
            this.Parts = new List<Part>();
        }
    }

    // Класс поставки запчастей
    public class Supply
    {
        public int SupplyId { get; set; } // PrimaryKey

        // Ссылка на поставщика, доставляющего поставку
        public int SupplierId { get; set; }
        public virtual Supplier? Supplier { get; set; }
        // Ссылка на кладовщика, сопровождающего поставку
        public int EmployeeId { get; set; }
        public virtual Employee? Employee { get; set; }

        public DateTime? DateOfPost { get; set; }
        public bool Delivered { get; set; }
        public DateTime? DateOfDelivery { get; set; }

        // Навигационные свойства
        /*
         * M:M - запчасти в поставке
         */
        public virtual List<Part> Parts { get; set; } // запчасти в поставке
        public virtual List<Position> Positions { get; set; } // позиции поставки
        
        public Supply()
        {
            this.Parts = new List<Part>();
            this.Positions = new List<Position>();
        }
    }

    // Класс позиций поставок с количеством запчастей
    public class Position
    {
        // Ссылка на поставки
        public int SupplyId { get; set; }
        public virtual Supply? Supply { get; set; }

        // Ссылка на запчасти
        public int PartId { get; set; }
        public virtual Part? Part { get; set; }

        public int Amount { get; set; }
    }
}
