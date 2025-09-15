namespace Design_Patterns_Demo.Builder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class House
    {
        public string Walls {  get; set; }
        public string Roof { get; set; }
        public string Garden { get; set; }

        public override string ToString()
        {
            return $"House with {Walls} , {Roof} and {Garden}.";
        }
    }
}
