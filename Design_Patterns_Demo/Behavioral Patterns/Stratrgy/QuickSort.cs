using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Demo.Behavioral_Patterns.Stratrgy
{
    public class QuickSort : ISortingStrategy
    {
        public void Sort(int[] numbers)
        {
            Console.WriteLine("Sorting using QuickSort technique");
        }
    }
}
