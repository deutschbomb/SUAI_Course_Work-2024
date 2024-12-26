
using System.Text.RegularExpressions;

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
        public string GetOwner
        {
            get
            {
                if (this.OwnerName is not null)
                    if (this.OwnerPatronymic is not null)
                        return String.Format("{0}: {1} {2}. {3}.",
                                this.OwnerPassportNumber, this.OwnerSurname, this.OwnerName[0], this.OwnerPatronymic[0]);
                    else return String.Format("{0}: {1} {2}.", this.OwnerPassportNumber, this.OwnerSurname, this.OwnerName[0]);
                else return String.Format("{0}: {1}", this.OwnerPassportNumber, this.OwnerSurname);
            }
        }

        // Навигационные свойства
        public virtual List<Request> Requests { get; set; } // заявки владельца на ремонт

        public override string ToString()
        {
            return Regex.Replace(this.OwnerPassportNumber, @"(\d{4})(\d{6})", @"$1 $2");
        }

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
        public string GetCar
        {
            get
            {
                return this.ModelName + ": " + Regex.Replace(this.VehicleIdentificationNumber,
                    @"([АВЕКМНОРСТУХ]{1})(\d{3})([АВЕКМНОРСТУХ]{2})", @"$1 $2 $3");
            }
        }

        // Навигационные свойства
        public virtual List<Request> Requests { get; set; } // заявки на ремонт автомобиля

        public override string ToString()
        {
            return Regex.Replace(this.VehicleIdentificationNumber, @"(\d{3})(\d{6})(\d{8})", @"$1 $2 $3");
        }

        public Car()
        {
            this.Requests = new List<Request>();
        }
    }
}
