namespace Design_Patterns_Demo.Builder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ConstructionEngineer
    {
        private readonly IHouseBuilder _houseBuilder;
        public ConstructionEngineer(IHouseBuilder houseBuilder)
        {
            _houseBuilder = houseBuilder;
        }

        public House ConstructHouse()
        {
            _houseBuilder.BuildWalls();
            _houseBuilder.BuildRoof();
            _houseBuilder.BuildGarden();
            return _houseBuilder.GetHouse();
        }
    }
}
