﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._03_StringsChallenge
{
    
    class Program
    {
        static void Main(string[] args)
        {

            /*  Bronze Challenge: 
                    Research MSDN docs and lean about working with strings in C#
                    Create examples that show techniques for basic string manipulation
                    show how to concatenate multiple strings, 
                    use composite formating, 
                    show how to use escapes, 
                    and how to manipulate numbers(eg, dollars & commas).
             */
            /*
                        //Concatenate multiple strings
                          string name = "Sue";
                          string location = "IndyZoo";
                          int age = 22;
                          Console.WriteLine("My name is " + name + ". How do you do?  I am " + age + " and I am going to visit the " + location + ".");
                          Console.ReadLine();
             */
            /*
                       //Composite formatting
                         string name = "Sue";
                         string location = "IndyZoo";
                         int age = 22;
                         Console.WriteLine("My name is {0}. I'm going to visit the {1} at age {2}.", name, location, age);
                         Console.ReadLine();
            */
            /*
                       //Escapes
                         string name = "Sue";
                         string location = "IndyZoo";
                         int age = 22;
                         Console.WriteLine("My name is " + name + ".\nHow do you do?\nI am " + age + " and I am going to visit the " + location + ".");
                         Console.ReadLine();
            */

            //TODO - Complete Strings_Challenges
            //Manipulate numbers 
            /*
                        decimal dec = 235.00M;
                        string money = dec.ToString("C");
                        Console.WriteLine(money);
                        Console.ReadLine();
             */

            /* Silver Challenge:
                    Create a note to a potential employer that states your goals as a developer.
                    Include the date in the string that is converted to a short date string.
                       Create 2 strings: Your user name in lowercase, and in uppercase,
                    Write code that compares the two strings and prints.
            */
            /*
                        DateTime dateToDisplay = new DateTime(2016, 3, 11);
                        Console.WriteLine("   {0}", dateToDisplay.ToString("d"));

                        Console.WriteLine("Dear Ms. Jones,\nToday is" + "{0}", dateToDisplay.ToString("d") + ". I enjoy the class and learning C#.\nWhen I complete the course, I would like to get a developer job.\nThank you,\nL. Decker");
                        Console.ReadLine();

            */
            /* Gold Challenge: 
                    Create 2 strings: Your username in lowercase, and in uppercare. 
                    Print one sentence that says they are equal.
                    Print a second sentence that says they are not equal.
            */

            string lower = "ldecker";
            string upper = "LDECKER";
            bool result1 = lower.Equals(upper, StringComparison.Ordinal);
            bool result2 = lower.Equals(upper, StringComparison.OrdinalIgnoreCase);

            Console.WriteLine("Ordinal comparison: {0} and {1} are {2}", lower, upper,
                                result1 ? "equal." : "not equal.");
            Console.WriteLine("OrdinalIgnoreCase comparison: {0} and {1} are {2}", lower, upper,
                                result2 ? "equal." : "not equal.");

            Console.ReadLine();

        }
    }
}
//Control + x with delete a line
