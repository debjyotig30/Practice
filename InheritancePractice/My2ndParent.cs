using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.InheritancePractice
{
    public class My2ndParent
    {
       public void someMethod()
        {
            Console.WriteLine("In Parent, someMethod...");
            MyChild myChild = new MyChild();
            myChild.methodinChild();
        }
        
    }
}
