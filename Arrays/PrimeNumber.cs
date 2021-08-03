using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Arrays
{
    class PrimeNumber : IPractice
    {
        public void execute()
        {
            long num1, num2, count1 = 0, count2 = 0;
            Console.Write("Enter lower range: ");
            num1 = long.Parse(Console.ReadLine());
            Console.Write("Enter upper range: ");
            num2 = long.Parse(Console.ReadLine());
            Console.WriteLine("Prime numbers between {0} and {1} are: ", num1, num2);
            Console.WriteLine("==============================================");
            for (long i = num1; i < num2; i++)
            {
                count1 = 0;
                if (i > 1)
                {
                    for (long j = 2; j < j/2; j++)
                    {
                        if (i % j == 0)
                        {
                            count1 = 1;
                            break;
                        }
                    }
                    if (count1 == 0)
                    {
                        count2++;
                        Console.Write(i + " ");
                    }
                }


            }
            Console.WriteLine();
            Console.WriteLine("We found {0} prime numbers.", count2);
            Console.ReadKey();
        }
    }
}
