using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    // Класс владельца автомобиля
    public class Owner
    {
        public int Id { get; set; } // PrimaryKey
        public string? OwnerSurname { get; set; }
        public string? OwnerName { get; set; }
        public string? OwnerPatronymic { get; set; }
        public string? OwnerPassportNumber { get; set; }
        public string? OwnerAddress { get; set; }
        public string? OwnerTelephone { get; set; }

        // Навигационные свойства
        public virtual List<Request> Requests { get; set; } // заявки владельца на ремонт

        public Owner()
        {
            this.Requests = new List<Request>();
        }
    }

    // Класс автомобиля
    public class Car
    {
        public int Id { get; set; } // PrimaryKey
        public string? BrandName { get; set; }
        public string? ModelName { get; set; }
        public string? VehicleIdentificationNumber { get; set; }
        public string? LicensePlate { get; set; }
        public string? BodyType { get; set; }
        public string? Color { get; set; }
        public string? TransmissionType { get; set; }
        public string? FuelType { get; set; }
        public string? WheelDriveType { get; set; }
        public byte? Generation { get; set; }
        public byte? Facelift { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }

        // Навигационные свойства
        public virtual List<Request> Requests { get; set; } // заявки на ремонт автомобиля

        public Car()
        {
            this.Requests = new List<Request>();
        }
    }
}
