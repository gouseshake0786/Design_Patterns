using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Demo.Behavioral_Patterns.Stratrgy
{
    // Strategy Interface
    public interface ISortingStrategy
    {
        void Sort(int[] numbers);
    }
}
