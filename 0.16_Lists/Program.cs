using System;//The console class lives here
using System.Collections.Generic;//The list class lives here
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._16_Lists //A list is an object which holds variables in a specific order.
                       //The type of variables that a list can store is defined using the generic syntax.
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>//lists use angle brackets
              {
                  "James", "Paul", "Kenn", "Jenn", "Sheriff" //list is indexed 0, 1, 2, 3, 4
              };
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            names.Add("Devan");//This adds Devan to the list
            Console.WriteLine("=================");
            foreach (var name in names)
            {
                Console.WriteLine(names);


            }
        }
    }
}

