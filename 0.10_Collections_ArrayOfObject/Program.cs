using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_Collections_ArrayOfObject//An array stores a fixed-size sequential collectiom of elements of the same type
                    //Lists are like arrays, but they can grow as you use them.  Not fixed size.
                    //Queue - fifo - first in first out.  Like a line at the ticket office.  Need to look it up to use.
                    //Stacks - lifo - last in first out.  Like a stack of dishes - take it off the top.  Need to look it up to use.
{
    class Item
    {
        public int ID { get; set; }
        public Item (int id)
        {
            ID = id;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            var items = new Item[5];//new array with 5 items
            Random r = new Random(); //Random class created
            for(int i =0; i < items.Length; i++)//goes through every item in the array.  items.Length is safe way to work with any size array 
            {
                items[i] = new Item(r.Next());
            }
            Console.WriteLine("Items: ");

            foreach(Item item in items)//A foreach loop lets you do the requested work for each one 
            {
                Console.WriteLine("ItemID = {0}", item.ID);//this displays each id 
            }

           Item myItem = items[1]; //to see the second id in the array, because the array starts at zero
           Console.WriteLine("The ID of the second item is {0}", myItem.ID);

   // Array.Sort is a built in method in arrays.  There are others you can use.  Find them in the documentation.

        }
    }
}