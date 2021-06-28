using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.InheritancePractice
{
    class MySecondChild : MyParent
    {
        public override void doSomething()
        {
            Console.WriteLine("My second child did something...");
        }

        public override void printStatus()
        {
            Console.WriteLine("This is my second Child.");
        }
    }
}
