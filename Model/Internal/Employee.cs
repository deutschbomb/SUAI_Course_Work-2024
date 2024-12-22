
namespace App
{
    // Класс должности
    public class Specialty
    {
        public int SpecialtyId { get; set; } // PrimaryKey
        public string? SpecialtyName {  get; set; }

        // Навигационные свойства
        public virtual List<Employee> Employees { get; set; } // сотрудники, занимающие должности

        public Specialty()
        {
            this.Employees = new List<Employee>();
        }
    }

    // Класс сотрудника
    public class Employee
    {
        public int EmployeeId { get; set; } // PrimaryKey

        // Ссылка на должность
        public int SpecialtyId { get; set; }
        public virtual Specialty? Specialty { get; set; }

        public string? EmployeeName { get; set; }
        public string? EmployeeSurame { get; set; }
        public string? EmployeePatronymic { get; set; }
        public string? EmployeePassportNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? EmployeeAddress { get; set; }
        public string? EmployeeTelephone { get; set; }
        public DateTime DateOfEmployment { get; set; }

        // Навигационные свойства
        public virtual List<Request> Requests { get; set; } // заявки на ремонт
        public virtual List<Supply> Supplies { get; set; } // поставки, оформляемые кладовщиком
        /// <summary>
        /// M:M - заказ-наряд
        /// </summary>
        public virtual List<Part> Parts { get; set; } // установленные запчасти
        public virtual List<Work> Works { get; set; } // проводимые работы
        public virtual List<Order> Orders { get; set; } // заказ-наряд

        public Employee()
        {
            this.Requests = new List<Request>();
            this.Supplies = new List<Supply>();

            this.Parts = new List<Part>();
            this.Works = new List<Work>();
            this.Orders = new List<Order>();
        }
    }
}
