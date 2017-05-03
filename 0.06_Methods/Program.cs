using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._06_Methods//A method is a code block that contains a series of statments.  
//A program causes the statements to be executed by calling the method and specifying any required method arguments.
//In C# every executed instruction is performed in the context of a method.
{
    class Program
    {             
        //The Main method is the entry point for every C# application and it called by the common language runtime(CLR) when the program is started.
        static void Main(string[] args)             

        {
            Customer theJSWizard = new Customer();
            theJSWizard.AppearsWealthy = false;//set the properties for the JSWizard
            theJSWizard.FirstName = "James";
            theJSWizard.LastName = "Handshoe";
       

           // Console.WriteLine(); is not needed here, since it is called in the Customer class

            theJSWizard.PrintCustomerName();

            Customer theSherriff = new Customer();
            theSherriff.FirstName = "Sheriff";
            theSherriff.LastName = "Holler";
            theSherriff.PrintCustomerName();

            Customer theTeacher = new Customer();
            theTeacher.FirstName = "Paul";
            theTeacher.LastName = "O'Connor";
            theTeacher.PrintCustomerName();

            Customer Teacher = new Customer();
            Teacher.FirstName = "Ken";
            Teacher.LastName = "Pascascio";
            Teacher.PrintCustomerName();


            Console.ReadLine();


        }
    }
}
