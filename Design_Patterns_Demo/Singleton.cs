namespace Design_Patterns_Demo
{
    using System;

    public sealed class Singleton
    {
        private static readonly Lazy<Singleton> instance = new Lazy<Singleton>(() => new Singleton());

        private readonly int count = 0;
        private Singleton()
        {
            count++;
            Console.WriteLine(count.ToString());
        }

        public static Singleton Instance
        {
            get { return instance.Value; }
        }

        public void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}
