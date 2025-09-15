namespace Design_Patterns_Demo.Managers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IEmployeeManager
    {
        decimal GetBonus();
        decimal GetPay();
    }
}
