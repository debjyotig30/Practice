using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.StaticPolymorphism
{
    class BigCalculator : Calculator
    {
        public void execute()
        {
            BigCalculator bigC = new BigCalculator();
            bigC.Sum(1, 2, 3);
            bigC.Sum(1, 2);
        }
        public void Sum(int input1, int input2, int input3)
        {
            int sum = input1 + input2 + input3;
            Console.WriteLine("Sum = " + sum);
        }
    }
}
