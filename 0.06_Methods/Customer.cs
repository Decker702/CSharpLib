using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._06_Methods
{
    class Customer
    {

        // Writing order: 1) Field is variable of any type that is declared directly in a class or struct 
           //2) Property is a member that provides a flexible mechanism to read, write or compute the value of a private field, 
           //then 3) Method is a code block that contains a series of statments.  A program causes the statements to be executed
             //by calling the method and specifying any required method arguments.  In C#, every executed instruction is performed
             // in the context of a method.
             //The Main method is the entry point for every C# application and it called by the common language runtime(CLR) when the program is started.
        //PROPERTIES
        //following are properties, and they are inside of classes
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool AppearsWealthy { get; set; }
        public decimal BankRoll { get; set; }

        //camel case - use it for variables
        //string firstName

        //Pascal Casing - use for properties
        //public string FullName { get; set; }

        //METHODS - have active verbs ie. Writeline
        //public allows you to use it in another class
        public void PrintCustomerName()
        {
            Console.WriteLine("Hello, {0} {1}", FirstName, LastName);
        }
        public void AssessWealth()
        {
            if (AppearsWealthy)
            {
                Console.WriteLine("He looks loaded.");
            }
            else
            {
                Console.WriteLine("Did you see that car?");
                
  

            }
        }

    }
}
