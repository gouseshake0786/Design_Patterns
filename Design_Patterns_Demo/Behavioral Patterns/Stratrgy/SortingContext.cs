using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Demo.Behavioral_Patterns.Stratrgy
{
    public class SortingContext
    {
        private ISortingStrategy _sortingStrategy;

        public void SetStrategy(ISortingStrategy sortingStrategy)
        {
            _sortingStrategy = sortingStrategy;
        }

        public void SortArray(int[] numbers)
        {
            _sortingStrategy.Sort(numbers);
        }
    }
}
