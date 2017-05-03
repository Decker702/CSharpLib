using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_Constructors//Constructors are special methods of the class.  They are used to construct an instance of the class & populate the data.
{ //They have no return type and must have the name of the class. They take parameters, usually for each of the properties of the class
  //You construct the object by passing paramenters into the constructor at the time the object is created.

    class Employee
    {
        public int Age { get; set; }//Properties of the class.  
        public string Name { get; set; }//Properties are the way other methods of other classes interact with the data of the class
        public double Salary { get; set; }
        public DateTime StartingDate { get; set; }
        public string PhoneNumber { get; set; }

        public void Bonus(double bonusPercent)//This is a standard method of the class.   
        {                                      //Methods represent the behavior of the objects in that class
            Salary += Salary * bonusPercent;
        }
        //Constructor
        public Employee(int age, string name, double salary, DateTime startingDate, string phoneNumber)
        {
            Age = age;//In the body of the constructor you can assign and pass in the parameters of the property
            Name = name;
            Salary = salary;
            StartingDate = startingDate;
            PhoneNumber = phoneNumber;
        }
        //Method overloading is when you have two methods with the same name, but different parameters.  Different types or number of them.
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
            Dave.Bonus(0.05); //This give Dave a 5% bonus

            Employee Mary = new Employee(23, "Mary Smith", 60000, new DateTime(2010, 4, 22), "542-524-9685");
            //Creates an employees by passing in values to the constructor.  Not by intializing it.

        }
    }
}