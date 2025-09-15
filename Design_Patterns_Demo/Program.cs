namespace Design_Patterns_Demo
{
    using Design_Patterns_Demo.Builder;
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

            #endregion
        }
    }
}
