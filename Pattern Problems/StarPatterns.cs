using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Pattern_Problems
{
    class StarPatterns : IPractice
    {
        public void execute()
        {
            Console.Write("Enter n: ");
            int n = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Pattern 1:");
            pattern1(n);
            Console.WriteLine("\nPattern 2:");
            pattern2(n);
            Console.WriteLine("\nPattern 3:");
            pattern3(n);
            Console.WriteLine("\nPattern 4:");
            pattern4(n);
            Console.WriteLine("\nPattern 5:");
            pattern5(n);
            Console.WriteLine("\nPattern 6:");
            pattern6(n);
            Console.WriteLine("\nPattern 7:");
            pattern7(n);
        }

        public void pattern1(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }

        public void pattern2(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                    Console.Write("*");

                Console.WriteLine("");
            }
        }

        public void pattern3(int n)
        {

            for (int i = 1; i <=n; i++)
            {
                for(int j=1; j<=n-i; j++)
                    Console.Write(" ");

                for (int k=1; k<=i; k++)
                    Console.Write("*");

                Console.WriteLine("");
            }
        }

        public void pattern4(int n)
        {
            for (var i = 1; i <= n; i++)
            {
                for (var j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= (2*i - 1); k++)
                    Console.Write("*");

                Console.WriteLine("");
            }
        }

        public void pattern5(int n)
        {
            for (int i = 1; i < n; i++)
            {
                for (int j=1; j<=n; j++)
                    Console.Write("*");
                
                Console.WriteLine("");
            }
        }

        public void pattern6(int n)
        {
            for (int i=0; i<n; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
            for (int j = 1; j <= n - 2; j++)
            {
                Console.Write("*");
                for (int k = 1; k < n-1; k++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                Console.WriteLine("");
            }
            //Console.WriteLine("");
            for (int i = 0; i < n; i++)
            {
                Console.Write("*");
            }
        }

        public void pattern7(int n)
        {
            for (int i = 0; i < (n - 1);i++)
            {
                for(int j=0; j<(n-1);j++)
                {
                    Console.Write('_');
                }
                Console.WriteLine("");
            }

            for (int k=0; k<((2*n)-1); k++)
            {
                Console.Write('*');
            }
        }
    }
}
