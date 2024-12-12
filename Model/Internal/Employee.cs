using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoService.Model.Parts;
using AutoService.Model.Sevice;

namespace AutoService.Model.Internal
{
    // Класс сотрудника
    public class Employee
    {
        public int Id { get; set; } // PrimaryKey
        public string? EmployeeName { get; set; }
        public string? EmployeeSurame { get; set; }
        public string? EmployeePatronymic { get; set; }
        public string? EmployeePassportNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? EmployeeAddress { get; set; }
        public string? EmployeeTelephone { get; set; }
        public DateTime DateOfEmployment { get; set; }
    }
}
