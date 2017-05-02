using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_WhileLoop//Allows you to do some work, while condition is true.
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you? ");
            int age = int.Parse(Console.ReadLine());//Combines Parse & ReadLine for dry code
                                            //Above prints on the console How old are you and waits for a response.
            while (age > 0)  //An age is input, the console prints out Hello that number of times & stops at zero.
                              //While loop continues as long as age is greater than zero, when zero the While test fails
                              //When the While test fails, it then falls through the bottom of the While loop
            {
                Console.WriteLine("Hello ");
                age--;// can also be written as age = a-1; or age -= 1;
            }
            Console.WriteLine("\nTaDa!!");//After the While loop failed, the system falls to the next statement
                                        //In the console the above would move to the next line \n, and print TaDa!!
        }
    }
}
/*
 * Do While Loop - In the While Loop, if zero was entered Hello was never printed.
 *                  To ensure Hello is printed at least once, use a Do While Loop
 *                  While Loop and Do While Loop only differ in that Do While will work
 *                  at least once before it runs the test.
 * 
 * 
            Console.WriteLine("How old are you? ");
            int age = int.Parse(Console.ReadLine());

            do //do the work before do the test, so Hello will print at least once
            {
                Console.WriteLine("Hello ");
                age--;
            }
            
            while (age > 0)  //move the condition to the end of the block
*/
