namespace Design_Patterns_Demo.Factory
{
    using Design_Patterns_Demo.Vehicle;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class RoadLogistics : Logistics
    {
        public override IVehicle CreateVehicle()
        {
            return new Truck();
        }
    }
}
