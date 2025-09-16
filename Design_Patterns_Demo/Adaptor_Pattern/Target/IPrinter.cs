using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Demo.Adaptor_Pattern.Target
{
    // Target interface (what the client expects)
    public interface IPrinter
    {
        void Print(string message);
    }
}
