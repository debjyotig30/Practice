using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.InheritancePractice
{
    class InheritanceTester : IPractice
    {
        public void execute()
        {
            MyParent[] myParents = new MyParent[3];
            myParents[0] = new MyChild();
            myParents[1] = new MySecondChild();
            myParents[2] = new MyThirdChild();

            //This implements run-time polymorphism as it is decided at run time, method will be called from which class.
            // myParents array stores object of each class as its member item.

            foreach (MyParent parent in myParents)
            {
                parent.doSomething();
                parent.printStatus();
            }
        }
    }
}
