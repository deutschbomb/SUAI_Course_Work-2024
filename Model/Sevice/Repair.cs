using AutoService.Model.Internal;
using AutoService.Model.Parts;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService.Model.Sevice
{
    // Класс заявки на ремонт
    public class Request
    {
        public int Id { get; set; }  // PrimaryKey
        public DateTime RequestDate { get; set; }
        public DateTime StartDate { get; set; }
        public bool Completed { get; set; }
        public DateTime CompleteDate { get; set; }

        // Навигационные свойства
        public virtual List<Manager> Managers { get; set; } // ссылка на менеджеров, обрабатывающих заявку
        public virtual List<Owner> Owners { get; set; } // ссылка на владельцев (клиентов)
        public virtual List<Car> Cars { get; set; } // ссылка на автомобили, требующие ремонт

        // Ссылка на заказ-наряд
        public virtual Order? Order { get; set; }
        public int OrderID { get; set; }

        public Request()
        {
            Managers = new List<Manager>();
            Owners = new List<Owner>();
            Cars = new List<Car>();
        }
    }

    // Класс проводимой работы
    public class Work
    {
        public int Id { get; set; } // PrimaryKey
        public string? WorkType { get; set; }
        public string? WorkDescription { get; set; }
        public decimal WorkPrice { get; set; }

        // Ссылка на заказ-наряд
        public virtual Order? Order { get; set; }
        public int OrderID { get; set; }
    }

    // Класс заказ-наряда заявки на ремонт
    public class Order
    {
        // Навигационные свойства
        public virtual List<Request> Requests { get; set; } // ссылка на заявку на ремонт,
                                                            // для которой составляется заказ-наряд
        public virtual List<Work> Works { get; set; } // ссылка на проводимую работу во время ремонта
        public virtual List<Mechanic> Mechanics { get; set; } // ссылка на механиков, выполняющих ремонт
        public virtual List<Part> Parts { get; set; } // ссылка на установленные (возможно) запчасти

        public Order()
        {
            Requests = new List<Request>();
            Works = new List<Work>();
            Mechanics = new List<Mechanic>();
            Parts = new List<Part>();
        }
    }
}
