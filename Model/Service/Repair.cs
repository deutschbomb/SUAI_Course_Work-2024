
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

        public DateTime? RequestDate { get; set; }
        public DateTime? StartDate { get; set; }
        public bool Completed { get; set; }
        public DateTime? CompleteDate { get; set; }
    }
}
