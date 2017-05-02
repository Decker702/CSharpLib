using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_Constructors//Constructors are special methods of the class.  They are used to construct an instance of the class & populate the data
{ //They have no return type, not even void and they must have the name of the class. They take parameters, which commonly are for each of the properties of the class
  //In the body of the constructor you can assign these passed in parameters to the property.  
  //Now you can construct the object by passing paramenters in to the constructor at the time you create the object.
    class Employee//Classes define a type ojects are instances of that type.
    {
        public int Age { get; set; }//Properties of the class.  
        public string Name { get; set; }//Properties are way other methods of other classes interact with the data of the class
        public double Salary { get; set; }
        public DateTime StartingDate { get; set; }
        public string PhoneNumber { get; set; }

        public void Bonus(double bonusPercent)//This is a standard method of the class.   
        {                                      //Methods represent the behavior of the objects in that class
            Salary += Salary * bonusPercent;
        }
        //Constructors have no return type, not even void and they must have the name of the class. They take parameters, which commonly are for each of the properties of the class
        public Employee(int age, string name, double salary, DateTime startingDate, string phoneNumber)
        {
            Age = age;//In the body of the constructor you can assign these passed in parameters to the property
            Name = name;
            Salary = salary;
            StartingDate = startingDate;
            PhoneNumber = phoneNumber;
        }
        //Method overloading is when you have two methods with the same name, but different parameters.  Different types or number of them.
        public Employee()
        {
            //default constructor.
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