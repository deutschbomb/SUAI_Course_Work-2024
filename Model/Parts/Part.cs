
namespace App
{
    // Класс запчасти
    public class Part
    {
        public int PartId { get; set; } // PrimaryKey
        public string? CatalogueNumber { get; set; }
        public string? PartName { get; set; }

        // Навигационные свойства
        /// <summary>
        /// M:M - номенклатура
        /// </summary>
        public virtual List<Supplier> Suppliers { get; set; } // поставщики запчастей
        /// <summary>
        /// M:M - запчасти в поставке
        /// </summary>
        public virtual List<Supply> Supplies { get; set; } // поставки запчастей
        public virtual List<Position> Positions { get; set; } // позиции поставки
        /// <summary>
        /// 1:1 - запчасть на складе
        /// </summary>
        public virtual Accounting? Accounting { get; set; }
        /// <summary>
        /// M:M - заказ-наряд
        /// </summary>
        public virtual List<Employee> Employees { get; set; } // механики
        public virtual List<Work> Works { get; set; } // проводимые работы
        public virtual List<Order> Orders { get; set; } // заказ-наряд

        public string PartInfo
        {
            get
            {
                if (this.PartName is not null)
                    return this.CatalogueNumber + " - " + this.PartName;
                else return this.ToString();
            }
        }

        public override string ToString()
        {
            if (this.CatalogueNumber is not null) return this.CatalogueNumber;
            else return base.ToString();
        }

        public Part()
        {
            this.Suppliers = new List<Supplier>();

            this.Supplies = new List<Supply>();
            this.Positions = new List<Position>();

            this.Employees = new List<Employee>();
            this.Works = new List<Work>();
            this.Orders = new List<Order>();
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
