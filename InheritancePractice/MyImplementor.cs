using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.InheritancePractice
{
    class MyImplementor : MyInterface
    {
        void MyInterface.doSomething()
        {
            Console.WriteLine("Did Something in MyImplementor");
        }

        void MyInterface.printStatus()
        {
            Console.WriteLine("In MyImplementor...");
        }

        public void randomAction() {
            Console.WriteLine("Wow... You can really dance!!!");
        }
    }
}
