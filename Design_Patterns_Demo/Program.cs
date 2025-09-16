namespace Design_Patterns_Demo
{
    using Design_Patterns_Demo.Adaptor_Pattern.Adaptor;
    using Design_Patterns_Demo.Adaptor_Pattern.Target;
    using Design_Patterns_Demo.Behavioral_Patterns.Chain_Of_Responsibility;
    using Design_Patterns_Demo.Behavioral_Patterns.ObserverPattern;
    using Design_Patterns_Demo.Behavioral_Patterns.Stratrgy;
    using Design_Patterns_Demo.Builder;
    using Design_Patterns_Demo.Decorator;
    using Design_Patterns_Demo.Factory;
    using Design_Patterns_Demo.Furnitures;
    using Design_Patterns_Demo.Managers;
    using Design_Patterns_Demo.Prototype;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main(string[] args)
        {
            #region Singleton

            Singleton getUsers = Singleton.Instance;
            getUsers.Print("Calling from users singleton");

            Singleton getEmployees = Singleton.Instance;
            getUsers.Print("Calling from employees singleton");

            #endregion

            #region FactoryPattern
            Console.WriteLine("=========================================================================");
            EmployeeManagerFactory employeeManagerFactory = new EmployeeManagerFactory();
            IEmployeeManager employeeManager = employeeManagerFactory.GetEmployeeManager(2);
            decimal bonus = employeeManager.GetBonus();
            Console.WriteLine("Bonus Value : {0}", bonus);

            #region Factory Method
            Logistics road = new RoadLogistics();
            road.PlanDelivery();

            Logistics sea = new SeaLogistics();
            sea.PlanDelivery();
            #endregion

            #region Abstract Factory
            Console.WriteLine("=========================================================================");
            IFurnitureFactory victorianFactory = new VictorianFurnitureFactory();   
            IChair vChair = victorianFactory.CreateChair();
            ISofa vSofa =  victorianFactory.CreateSofa();
            vChair.SitOn();
            vSofa.LieOn();

            #endregion

            #endregion

            #region Builder Pattern
            Console.WriteLine("=========================================================================");
            IHouseBuilder builder = new SimpleHouseBuilder();
            //Console.WriteLine(builder.GetHouse());
            ConstructionEngineer engineer = new ConstructionEngineer(builder);
            House house = engineer.ConstructHouse();
            Console.WriteLine(house);
            #endregion

            #region Prototype Pattern
            Console.WriteLine("=========================================================================");
            Employee emp1 = new Employee { Id = 1 , Name = "John"};

            //clone employee
            Employee emp2 = emp1.Clone();
            emp2.Name = "Smith";
            Console.WriteLine(emp1);
            Console.WriteLine(emp2);
            #endregion

            #region Adaptor
            Console.WriteLine("====================== Adaptor ===================================");
            IPrinter printer = new PrinterAdapter(new Adaptor_Pattern.Adaptee.LegacyPrinter());
            printer.Print("Hello Adapter Pattern");


            #endregion

            #region Decorater Pattern
            Console.WriteLine("========================== Decorater ======================================");
            ICoffee coffee = new SimpleCoffee();
            Console.WriteLine($"{coffee.GetDescription()} => ${coffee.GetCost()}");

            // Add milk
            coffee = new MilkDecorator(coffee);
            Console.WriteLine($"{coffee.GetDescription()} => ${coffee.GetCost()}");

            // Add sugar
            coffee = new SugarDecorator(coffee);
            Console.WriteLine($"{coffee.GetDescription()} => ${coffee.GetCost()}");
            #endregion


            #region Behavioral Patrern
            #region Chain Of Resposibility
            Console.WriteLine("============================== Chain of resposibility ===========================");
            // Create handlers
            Handler level1 = new Level1Support();
            Handler level2 = new Level2Support();
            Handler level3 = new Level3Support();

            // Set chain: Level1 → Level2 → Level3
            level1.SetNext(level2);
            level2.SetNext(level3);

            // Send requests
            level1.HandleRequest(1);
            level1.HandleRequest(2);
            level1.HandleRequest(3);
            level1.HandleRequest(4); // No handler
            #endregion

            #region Observer Pattern
            Console.WriteLine("========================== Observer Pattern =============================");
            #endregion
            var subject = new Subject("Mahamad", 20);
            var observer = new Observer(subject);
            subject.UpdateUserAge(10);


            var subject1 = new Subject1("Mahamad", 20);
            var observer1 = new Observer1();
            subject1.Subscribe(observer1);
            subject1.UpdateUserAge(10);

            #region Strategy Pattern

            Console.WriteLine("========================== Strategy Pattern =============================");
            int[] numbers = { 5, 3, 8, 1 };

            SortingContext context = new SortingContext();

            // Use Bubble Sort
            context.SetStrategy(new BubbleSort());
            context.SortArray(numbers);

            // Use Quick Sort
            context.SetStrategy(new QuickSort());
            context.SortArray(numbers);
            #endregion
            #endregion
        }
    }
}
