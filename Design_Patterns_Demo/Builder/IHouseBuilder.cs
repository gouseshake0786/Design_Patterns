namespace Design_Patterns_Demo.Builder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IHouseBuilder
    {
        void BuildWalls();
        void BuildRoof();
        void BuildGarden();
        House GetHouse();
    }
}
