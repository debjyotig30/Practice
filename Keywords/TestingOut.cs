using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Keywords
{
    class TestingOut : IPractice
    {
        public void SquareFunction( int parameter1)
        {
            //int defaultInput = 3;
            //parameter1 = defaultInput;
            // this.parameter1 *= parameter1;
        }
        public void execute()
        {
            Console.WriteLine("Enter number to be squared:");
            int parameter1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Value before passing out parameter:" + parameter1);
            TestingOut testingOut = new TestingOut();
            testingOut.SquareFunction(parameter1);
            Console.WriteLine("Value after passing out parameter:" + parameter1);
        }
    }
}
