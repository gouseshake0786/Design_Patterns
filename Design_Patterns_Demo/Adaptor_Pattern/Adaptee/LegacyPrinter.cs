using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Demo.Adaptor_Pattern.Adaptee
{
    // Adaptee (existing/legacy class with different method)
    public class LegacyPrinter
    {
        public void PrintText(string text)
        {
            Console.WriteLine("Legacy Printer: " + text);
        }
    }
}
