﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_Constructors_base
{
    class Program
    {
        static void Main(string[] args)
        {
            //construtor 1
            Person kenn = new Person();
            kenn.FirstName = "Kenn";
            kenn.LastName = "Pascascio";
            kenn.Age = 40;
            kenn.TestMethod();

            //constructor 2
            Person kenn2 = new Person("Kenny", "Pascascio", 40);
            kenn2.TestMethod();

            Minor sophia = new Minor("Sophia", "O'Connor", 4, true);
            sophia.DemoMethod();
            sophia.TestMethod();

            Person jenn = new Minor("Jenn", "Aikins", 17, true);
            jenn.TestMethod();


            Minor jennA = new Minor("Jenn", "Aikins", 16, true);
            jennA.DemoMethod();
            jennA.TestMethod();

            Console.ReadLine();
        }
    }
}




