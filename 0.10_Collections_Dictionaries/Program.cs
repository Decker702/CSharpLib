using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_Collections_Dictionaries//Dictionaries have keys and values.  Key value pairs make up a dictionary.  Key most often is NOT an integer
      //In a Webster dictionary - the key is the word and the value the definition.  When you sort the key, the values come along
      //Typically key is short and value is complex. A Key is usually NOT an integer
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> capitals = new Dictionary<string, string>();//in <> need to put in type for key & value
            capitals.Add("Alabama", "Montgomery");
            capitals.Add("Alaska", "Junea");
            capitals.Add("Arizona", "Phoenix");
            capitals.Add("Indianapolis", "Indianapolis");//Key is name of the state and value is name of the capital
            capitals.Add("Massachusetts", "Boston");
            capitals.Add("Wyoming", "Cheyenne");

            string capitalOfMass = capitals["Massachusetts"];
            Console.WriteLine("The capital of Massachusetts is {0}", capitalOfMass);

        }
    }
}
