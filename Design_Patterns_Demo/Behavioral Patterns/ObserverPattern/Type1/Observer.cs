using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Demo.Behavioral_Patterns.ObserverPattern
{
    internal class Observer1 : IObserver<User1>
    {
        public void OnCompleted()
        {
            Console.WriteLine("Completed");
        }

        public void OnError(Exception error)
        {
            Console.WriteLine("Error");
        }

        public void OnNext(User1 value)
        {
            Console.WriteLine($"Name: {value.Name}, Age: {value.Age}");
        }
    }
}
