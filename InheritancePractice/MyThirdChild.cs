using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.InheritancePractice
{
    class MyThirdChild : MyParent
    {
        public override void doSomething()
        {
            Console.WriteLine("Third Child did something...");
        }

        public override void printStatus()
        {
            Console.WriteLine("This is my third Child...");
        }
    }
}
