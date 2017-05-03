using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_Constructors_base
{//base keyword calls up to the person constructor public Minor(string firstName, string lastName, int age, bool IsInSchool)
    //    : base(firstName, lastName, age) 
    //this in inherited from the parent, which is named Person.
    public class Minor : Person
    {

        public Minor(string firstName, string lastName, int age, bool isInSchool) : base(firstName, lastName, age)
        {
            this.IsInSchool = isInSchool;
        }
        //Property
        public bool IsInSchool { get; set; }

        //Methods
        public override void TestMethod()
        {
            Console.WriteLine("Test method in Minor class");
        }

        public void DemoMethod()
        {
            Console.WriteLine("Demo method in Minor class");
        }

    }
}
