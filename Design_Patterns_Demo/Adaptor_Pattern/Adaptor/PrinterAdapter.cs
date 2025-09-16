using Design_Patterns_Demo.Adaptor_Pattern.Adaptee;
using Design_Patterns_Demo.Adaptor_Pattern.Target;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Demo.Adaptor_Pattern.Adaptor
{
    // Adapter (converts interface of Adaptee to Target)
    public class PrinterAdapter : IPrinter
    {
        private readonly LegacyPrinter _legacyPrinter; 
        public PrinterAdapter(LegacyPrinter legacyPrinter)
        {
            _legacyPrinter = legacyPrinter;
        }
        public void Print(string message)
        {
            _legacyPrinter.PrintText(message);
        }
    }
}
