﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_else_if
{
    class Program
    {//You can nest an if statement inside an else block.  You can use any valid Boolean expression for the condition.
        static void Main(string[] args)
        {
            int bankAccount = 50000;
            int debt = 13500;
            int difference = bankAccount - debt;

            int taxSeason = 40000;
            difference = -taxSeason;

                Console.WriteLine("I have {0:C} in my bank account and I am {1:C} in debt", bankAccount, debt);
            if (difference >= 7000)
            {
                Console.WriteLine("I have extra money to buy socks this month.");
            }
            else if (difference < 6999 && difference > 2000)
            {
                Console.WriteLine("We got get rid of the dog.");
            }
            else
            {
                Console.WriteLine("Looks like I'm living with the 'rents this month.");
            }

            Console.ReadLine();
       
        }
    }
}
// To comment out a whole section of code - highlight section to comment & select comment out button on top tool bar.
// The comment out icon on the tool bar is next to the uncomment out icon.