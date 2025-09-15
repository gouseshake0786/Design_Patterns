namespace Design_Patterns_Demo.Factory
{
    using Design_Patterns_Demo.Vehicle;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Logistics
    {
        public abstract IVehicle CreateVehicle();
        public void PlanDelivery()
        {
            IVehicle vehicle = CreateVehicle();
            vehicle.Deliver();
        }
    }
}
