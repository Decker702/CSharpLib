using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._08_Methods_Overloading
/* Method overloading is what happens when you have two methods with the same name, but different signatures.
     Only the method name and its parameters type(not paramenter names) are part of the signature.
     They must have unique a name, unique paramenter types or pass their arguments differently.
   At compile time, the compiler works out which one is called, base on the compile time types of the arguments
     and the target of the method call.
   Because only methods, constructors, and indexed properties can have parameters, only those members can be overloaded.
*/
{
    class Employee
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public DateTime StartingDate { get; set; }
        public string PhoneNumber { get; set; }

        //One method named public Employee
        public Employee(int age, string name, double salary, DateTime startingDate, string phoneNumber)
        {
            Age = age;
            Name = name;
            Salary = salary;
            StartingDate = startingDate;
            PhoneNumber = phoneNumber;
        }
        //Second method named public Employee
        public Employee()
        {

        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Employee Dave = new Employee()//A default constructor takes no arguments.  This one is intialized below
            {
                Age = 34,
                Name = "Dave Jones",
                Salary = 50000.00,
                StartingDate = new DateTime(2012, 7, 10),
                PhoneNumber = "543-235-1212"
            };

            Console.WriteLine("Dave's age is {0} he started on {1} and makes{3}.", Dave.Age, Dave.StartingDate, Dave.Salary);

            Employee Mary = new Employee(23, "Mary Smith", 60000, new DateTime(2010, 4, 22), "542-524-9685");
            //Creates an employees by passing in values to the constructor.  Not by intializing it.

        }
    }
}

