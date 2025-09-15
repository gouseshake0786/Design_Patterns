namespace Design_Patterns_Demo.Factory
{
    using Design_Patterns_Demo.Managers;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class EmployeeManagerFactory
    {
        public IEmployeeManager GetEmployeeManager(int employeeTypeId)
        {
            switch (employeeTypeId)
            {
                case 1:
                    return new PermanentEmployeeManager();
                case 2:
                    return new ContractEmployeeManager();
                default:
                    throw new ArgumentException("Invalid Manager Type");
            }
        }
    }
}
