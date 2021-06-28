using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Arrays
{
    class Fibonacci: IPractice
    {
        public void execute()
        {
            //Console.Write("Enter the first number of the series: ");
            //int firstNumber = Int32.Parse(Console.ReadLine());

            //Console.Write("Enter the second number of the series: ");
            //int secondNumber = Int32.Parse(Console.ReadLine());

            Console.Write("Enter the length of the series: ");
            int seriesLength = Int32.Parse(Console.ReadLine());

            fibonacci(seriesLength);

            static void fibonacci(int seriesLength)
            {
                int[] fibonacciSeries = new int[seriesLength];
                fibonacciSeries[0] = 0;
                fibonacciSeries[1] = 1;

                if (seriesLength > 0)
                {
                    Console.WriteLine("The Fibonacci series is:" + "\n0" + "\n1");
                    for (int i = 2; i < seriesLength; i++)
                    {
                        fibonacciSeries[i] = fibonacciSeries[i - 1] + fibonacciSeries[i - 2];
                        Console.WriteLine(""+fibonacciSeries[i]);
                    }
                }
                Console.WriteLine("Find which element of series:");
                int input = Int32.Parse(Console.ReadLine());

                Console.WriteLine("The element is:" +fibonacciSeries[input]);

                //Console.WriteLine("The Fibonacci Series is:" + fibonacciSeries.ToString());
            }
        }
    }
}
