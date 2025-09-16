using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Demo.Decorator
{
    // Component interface
    public interface ICoffee
    {
        string GetDescription();
        double GetCost();
    }
}
