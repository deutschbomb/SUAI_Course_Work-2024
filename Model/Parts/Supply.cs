
namespace App
{
    // Класс поставщика запчастей
    public class Supplier
    {
        public int SupplierId { get; set; } // PrimaryKey
        public string? TaxpayerIdentificationNumber { get; set; }
        public string? SupplierName { get; set; }

        // Навигационные свойства
        public virtual List<Supply> Supplies { get; set; } // осуществляемые поставки
        /// <summary>
        /// M:M - номенклатура
        /// </summary>
        public virtual List<Part> Parts { get; set; } // поставляемые запчасти

        public string SupplierInfo
        {
            get {
                if (this.SupplierName is not null)
                    return this.TaxpayerIdentificationNumber + " - " + this.SupplierName;
                else return this.ToString();
            }
        }

        public override string ToString()
        {
            if (this.TaxpayerIdentificationNumber is not null)
                return this.TaxpayerIdentificationNumber;
            else return base.ToString();
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

        // Ссылка на поставщика, совершающего поставку
        public int SupplierId { get; set; }
        public virtual Supplier? Supplier { get; set; }
        // Ссылка на кладовщика, сопровождающего поставку
        public int EmployeeId { get; set; }
        public virtual Employee? Employee { get; set; }

        public DateTime? DateOfPost { get; set; }
        public bool Delivered { get; set; }
        public DateTime? DateOfDelivery { get; set; }

        // Навигационные свойства
        /// <summary>
        /// M:M - запчасти в поставке
        /// </summary>
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
