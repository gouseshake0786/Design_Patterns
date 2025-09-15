namespace Design_Patterns_Demo.Vehicle
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Truck : IVehicle
    {
        public void Deliver()
        {
            Console.WriteLine("Deliverd via Truck");
        }
    }
}
