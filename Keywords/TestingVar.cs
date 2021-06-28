using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Keywords
{
    class TestingVar : IPractice
    {
        private string getString()
        {
            return "Hello World!!!";
        }

        private int getNumber()
        {
            return 10;
        }

        
        public void execute()
        {
            var i = "Hello......";
            Console.WriteLine(i);
            //i = 'a';
            Console.WriteLine(i);
            var variable1 = getString();
            Console.WriteLine("variable1 = " + variable1);
            var variable2 = getNumber();
            Console.WriteLine("variable2 = " + variable2);
        }
    }
}
