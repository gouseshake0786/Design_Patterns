namespace Design_Patterns_Demo.Builder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SimpleHouseBuilder : IHouseBuilder
    {
        private House house = new House();
        public void BuildGarden()
        {
            house.Walls = "Brick Walls";
        }

        public void BuildRoof()
        {
            house.Roof ="Tailed Roof";
        }

        public void BuildWalls()
        {
            house.Garden = "Small Garden";
        }

        public House GetHouse()
        {
            return house;
        }
    }
}
