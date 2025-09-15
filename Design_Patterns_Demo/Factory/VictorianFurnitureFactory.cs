namespace Design_Patterns_Demo.Factory
{
    using Design_Patterns_Demo.Furnitures;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class VictorianFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair()
        {
            IChair chair = new VictorianChair();
            return chair;
            
        }

        public ISofa CreateSofa()
        {
            ISofa sofa = new VictorianSofa();
            return sofa;
        }
    }
}
