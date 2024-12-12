using AutoService.Model.Parts;
using AutoService.Model.Sevice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService.Model.Internal
{
    /// <summary>
    /// Класс менеджера, наследуемый от сотрудника
    /// Только менеджеры могут обрабатывать заявки на ремонт
    /// </summary>
    public class Manager : Employee
    {
        // Ссылка на заявку
        public virtual Request? Request { get; set; }
        public int RequsetId { get; set; }
    }

    /// <summary>
    /// Класс механика, наследуемый от сотрудника
    /// Только механики фигурируют в заказ-наряде
    /// </summary>
    public class Mechanic : Employee
    {
        // Ссылка на заказ-наряд
        public virtual Order? Order { get; set; }
        public int OrderID { get; set; }
    }

    /// <summary>
    /// Класс кладовщика, наследуемый от сотрудника
    /// Только кладовщик может обрабатывать поставки автозапчастей
    /// </summary>
    public class Storekeeper : Employee
    {
        // Ссылка на поставку
        public virtual Supply? Supply { get; set; }
        public int SupplyID { get; set; }
    }
}
