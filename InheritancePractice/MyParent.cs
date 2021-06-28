using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.InheritancePractice
{
    public abstract class MyParent
    {
        public abstract void doSomething();
        public virtual void printStatus()
        {
            Console.WriteLine("In MyParent...");
        }
    }
}
