
namespace App
{
    // Класс должности
    public class Specialty
    {
        public int SpecialtyId { get; set; } // PrimaryKey
        public string? SpecialtyName { get; set; }

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
        public string? EmployeeSurname { get; set; }
        public string? EmployeePatronymic { get; set; }
        public string? EmployeePassportNumber { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? EmployeeAddress { get; set; }
        public string? EmployeeTelephone { get; set; }
        public DateTime? DateOfEmployment { get; set; }
        public string GetEmployee
        {
            get
            {
                if (this.EmployeeName is not null)
                    if (this.EmployeePatronymic is not null)
                        return String.Format("{0}: {1} {2}. {3}.",
                                this.EmployeeId, this.EmployeeSurname, this.EmployeeName[0], this.EmployeePatronymic[0]);
                    else return String.Format("{0}: {1} {2}.", this.EmployeeId, this.EmployeeSurname, this.EmployeeName[0]);
                else return String.Format("{0}: {1}", this.EmployeeId, this.EmployeeSurname);
            }
        }

        // Навигационные свойства
        public virtual List<Request> Requests { get; set; } // заявки на ремонт
        public virtual List<Supply> Supplies { get; set; } // поставки, оформляемые кладовщиком
        
        public override string ToString()
        {
            if (this.EmployeeName is not null)
                if (this.EmployeePatronymic is not null)
                    return String.Format("{0} {1}. {2}.",
                            this.EmployeeSurname, this.EmployeeName[0], this.EmployeePatronymic[0]);
                else return String.Format("{0} {1}.", this.EmployeeSurname, this.EmployeeName[0]);
            else return this.EmployeeSurname;
        }

        public Employee()
        {
            this.Requests = new List<Request>();
            this.Supplies = new List<Supply>();
        }
    }
}
