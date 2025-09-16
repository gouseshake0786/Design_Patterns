using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Demo.Behavioral_Patterns.ObserverPattern
{
    internal class Observer
    {
        public Observer(ISubject subject)
        {
            subject.UserChanged += subject_UserChanged;
        }
        public event Action<User> UserChanged;

        private void subject_UserChanged(User user)
        {
            Console.WriteLine($"Name: {user.Name} , Age: {user.Age}");
        }
    }
}
