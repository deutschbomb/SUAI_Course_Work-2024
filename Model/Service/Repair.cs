
namespace App
{
    // Класс заявки на ремонт
    public class Request
    {
        public int RequestId { get; set; } // PrimaryKey

        // Ссылка на владельца автомобиля
        public int OwnerId { get; set; }
        public virtual Owner? Owner { get; set; }
        // Ссылка на ремонтируемый автомобиль
        public int CarId { get; set; }
        public virtual Car? Car { get; set; }
        // Ссылка на менеджера, обрабатывающего заявку
        public int EmployeeId { get; set; }
        public virtual Employee? Employee { get; set; }

        public DateTime RequestDate { get; set; }
        public DateTime StartDate { get; set; }
        public bool Completed { get; set; }
        public DateTime CompleteDate { get; set; }
    }

    // Класс проводимой работы
    public class Work
    {
        public int WorkId { get; set; } // PrimaryKey
        public string? WorkType { get; set; }
        public string? WorkDescription { get; set; }
        public decimal WorkPrice { get; set; }

        // Навигационные свойства
        /// <summary>
        /// M:M - заказ-наряд
        /// </summary>
        public virtual List<Part> Parts { get; set; } // установленные запчасти
        public virtual List<Employee> Employees { get; set; } // механики
        public virtual List<Order> Orders { get; set; } // заказ-наряд

        public Work()
        {
            this.Parts = new List<Part>();
            this.Employees = new List<Employee>();
            this.Orders = new List<Order>();
        }
    }

    public class Order
    {
        // Ссылка на работу, проводимую механиком
        public int WorkId { get; set; }
        public virtual Work? Work { get; set; }
        // Ссылка на механика, проводившего работу
        public int EmployeeId { get; set; }
        public virtual Employee? Employee { get; set; }
        // Ссылка на установленную запчасть
        public int PartId { get; set; }
        public virtual Part? Part { get; set; }
    }
}
