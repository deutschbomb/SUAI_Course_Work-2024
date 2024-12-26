
namespace App
{
    // Класс запчасти
    public class Part
    {
        public int PartId { get; set; } // PrimaryKey
        public string? CatalogueNumber { get; set; }
        public string? PartName { get; set; }
        public string GetPart
        {
            get { return this.ToString(); }
        }

        // Навигационные свойства
        /*
         * M:M - номенклатура
         */
        public virtual List<Supplier> Suppliers { get; set; } // поставщики запчастей
        /*
         * M:M - запчасти в поставке
         */
        public virtual List<Supply> Supplies { get; set; } // поставки запчастей
        public virtual List<Position> Positions { get; set; } // позиции поставки
        /*
         * 1:1 - запчасть на складе
         */
        public virtual Accounting? Accounting { get; set; }
        
        public override string ToString()
        {
            return this.CatalogueNumber + " - " + this.PartName;
        }

        public Part()
        {
            this.Suppliers = new List<Supplier>();

            this.Supplies = new List<Supply>();
            this.Positions = new List<Position>();
        }
    }

    // Класс учёта запчастей
    public class Accounting
    {
        // Ссылка на запчасть
        public int PartId { get; set; }
        public virtual Part? Part { get; set; }

        public int Balance { get; set; }
        public decimal PartPrice { get; set; }
    }
}
