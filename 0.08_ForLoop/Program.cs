using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._08_ForLoop  
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your starting Number: ");
            int startingNum = Int32.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Enter your ending Number: ");
            int endingNum = Int32.Parse(Console.ReadLine());

            //Uses startingNum and endingNum to create a for loop that adds every number in between?
            int sum = 0;
            for (int i = startingNum; i <= endingNum; i++)//Pattern is -- (set-up; test; change)
                //Logic is initialize once,test if true, run the body, do the change, test if true then run the body, continues until test is false
            {
                sum += i;
            }
            Console.WriteLine("The sum of all numbers between {0} and {1} is {2}", startingNum, endingNum, sum);
            Console.ReadLine();

        }
    }
}
