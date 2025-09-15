namespace Design_Patterns_Demo.Furnitures
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ModeranChair : IChair
    {
        public void SitOn()
        {
            Console.WriteLine("Sitting on Modern Chair");
        }
    }
    
}
