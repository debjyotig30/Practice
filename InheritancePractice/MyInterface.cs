using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.InheritancePractice
{
    interface MyInterface
    {
        public void doSomething();
        public void printStatus() {
            Console.WriteLine("In MyInterface...");
        }
    }
}
