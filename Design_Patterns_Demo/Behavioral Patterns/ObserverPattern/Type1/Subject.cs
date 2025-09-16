using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Demo.Behavioral_Patterns.ObserverPattern
{
    public interface ISubject1
    {
        event Action<User1> UserChanged;
        void UpdateUserAge(int age);
    }
    public class Subject1 : IObservable<User1>, IDisposable
    {
        private readonly User1 _user;
        private IList<IObserver<User1>> observers = new List<IObserver<User1>>();

        public Subject1(string name, int age)
        {
            _user = new User1 { Name = name, Age = age };
        }

        public void Dispose()
        {
            observers.Clear();
        }

        public IDisposable Subscribe(IObserver<User1> observer)
        {
            this.observers.Add(observer);
            observer.OnNext(_user);
            return this;

        }

        public void UpdateUserAge(int age)
        {
            _user.Age = age;
            foreach(var observer in observers)
            {
                observer.OnNext(_user);
            }
        }
    }
}
