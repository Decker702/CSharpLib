using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._05_Objects //Objects have specific properties and behaviors; 
{
  /*This is how it can be done in one file
    class Employee  //Class defines complex types, which includes fields which are data and properties are methods which represent behavior
    {
        /*
                private int age; //backing variable age.  A field is a member, can be private - only seen by methods of the class itself, or 
                                 //    public can be seen by any method of any class.  Private variable is lower case and Public is upper Case
                public int Age  // Access to the age through a property
                {
                    get { return age; }
                    set { age = value; }
         */
 /*       public int Age { get; set; } //This is the same as above in just one line
        public string Name { get; set; }
        public double Salary { get; set; }
        public DateTime StartingDate { get; set; }
        public string PhoneNumber { get; set; }

        //Methods are simply functions that are members of the class. 
        //Most methods have a return type or void, they take zero or more parameters, & there is a body to the method.
        public void Bonus(double bonusPercent)//This is a method.  It is void because it returns no value, Argument is double called bonusPercent,
        {                                       //body adds to the salary the salary*bonusPercent.
            Salary += Salary * bonusPercent;
        }

    }
    */
    class Program
    {
        static void Main(string[] args)
        {
 /*           Employee Dave = new Employee() //This is an instance or an object, they are synonyms.  Creates Dave as an instance of a new Employee.
            {// this initializes all the fields for the object Dave.
                Age = 34,
                Name = "Dave Jones",
                Salary = 50000.00,
                StartingDate = new DateTime(2012, 7, 10),
                PhoneNumber = "543-235-1212"
            };


            Console.WriteLine("Dave's age is {0} he started on {1} and makes{3}.", Dave.Age, Dave.StartingDate, Dave.Salary);
            Dave.Bonus(0.05); //This give Dave a 5% bonus
*/
            //This is how it is done with 2 files 
                Donuts appleCin = new Donuts();
                appleCin.Filling = "apple pie";
                appleCin.isSpecial = false;
                appleCin.Price = 0.99M;
                appleCin.Type = "Filled";

                Donuts longJohn = new Donuts();
                longJohn.Filling = "Barvarian Cream";
                longJohn.isSpecial = true;
                longJohn.Price = 1.25M;
                longJohn.Type = "Filled";

                Console.WriteLine("A longjohn cost about {0:C}.", longJohn.Price);


               // Console.WriteLine(appleCin.Filling);
                Console.ReadLine();
   
        }
    }

}
// Type prop and hit tab tab to get   public int MyProperty { get; set; }
//Press control, K and D to get your code to line up correctly