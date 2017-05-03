using System;//Using statements bring in already created/defined code to simplify your coding

namespace _0._01_Intro //Namespace is a container of related classes.
         //It has access to the Classes it contains.  
         //The using statments provide additional information to the namespace.

{
    class Program//Classes start with a capital letter.
        //Classes are the building blocks, which contain data and/or methods

    {
        static void Main(string[] args)//The Main method/function is how your program is entered by CLR & it is capitalized.
            //Within the () are the parameters. The () can, but doesn't have to contain parameters  -- it is optional.
            //Parameters are input and output.
            //void means this method does not return any value, just contains code.

        {//The information between {} are separate blocks of code.

           Console.WriteLine("Hello World");// a ; ends every statement.
           Console.ReadLine();//Displays Hello World in the console.
        }
    }
}
//Can add a using statement by hovering over the red squiggly lined word and hitting control + .
//Run application with control + F5