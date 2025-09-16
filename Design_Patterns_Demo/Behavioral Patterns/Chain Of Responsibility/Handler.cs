using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Demo.Behavioral_Patterns.Chain_Of_Responsibility
{
    // Handler Interface
    public abstract class Handler
    {
        protected Handler _nextHandler;

        public void SetNext(Handler nextHandler)
        {
            _nextHandler = nextHandler;
        }

        public abstract void HandleRequest(int level);
    }

    // Concrete Handlers
    public class Level1Support : Handler
    {
        public override void HandleRequest(int level)
        {
            if (level == 1)
                Console.WriteLine("Level 1 Support handled the request.");
            else if (_nextHandler != null)
                _nextHandler.HandleRequest(level);
        }
    }

    public class Level2Support : Handler
    {
        public override void HandleRequest(int level)
        {
            if (level == 2)
                Console.WriteLine("Level 2 Support handled the request.");
            else if (_nextHandler != null)
                _nextHandler.HandleRequest(level);
        }
    }

    public class Level3Support : Handler
    {
        public override void HandleRequest(int level)
        {
            if (level == 3)
                Console.WriteLine("Level 3 Support handled the request.");
            else
                Console.WriteLine("Request could not be handled.");
        }
    }

}
