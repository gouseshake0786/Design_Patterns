namespace Design_Patterns_Demo.Prototype
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Employee : IPrototype<Employee>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Employee Clone()
        {
            return (Employee)MemberwiseClone();
        }

        //4months BSC Computer 

        public override string ToString()
        {
            return $"Employee [Id = {Id}, Name = {Name}]";
        }
    }
}
