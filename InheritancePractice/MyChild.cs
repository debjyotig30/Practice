using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.InheritancePractice
{
    //class MyChild : MyParent, MyInterface, IPractice
    class MyChild : MyParent
    {

        public override void doSomething()
        {
            Console.WriteLine("Did something in MyChild...");
        }

        public void execute()
        {
            Console.WriteLine("Child Execute");
        }

        public override void printStatus()
        {
            Console.WriteLine("In MyChild...");
        }

        public void methodinChild()
        {
            Console.WriteLine("This is child's own method.");
        }
    }
}
