using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Arrays
{
    class GreatestElement : IPractice
    {
        public void execute2()
        {
            //Console.Write("Enter array: ");
            //int[] array = int.Parse(Console.ReadLine());
            //Console.Write("Enter d: ");
            //int d = int.Parse(Console.ReadLine());
            int[] arr1 = new int[3];
            int[] array = { 1, -2, 11, 4, 5 };
            int size = array.Length;
            int max = array[0];
            for (int i = 1; i < size; i++)
            {
                if (array[i] > max)// < array[i + 1])
                    max = array[i];
            }
            Console.WriteLine("Max = " + max);
        }
        public void execute()
        {
            //Console.Write("Enter array: ");
            //int[] array = int.Parse(Console.ReadLine());
            //Console.Write("Enter d: ");
            //int d = int.Parse(Console.ReadLine());

            int[] array = { 9, -2, 13, 4, 5 };
            int size = array.Length; //5
            int max = 0;
            Console.WriteLine("i\tarr[i-1]\tarr[i]\tmax");
            for (int i = 1; i < size; i++) //i = 0; i = 4
            {
                if (array[i - 1] < array[i]) // i = 1, 2 3 
                    max = array[i];      // max = 0 0
                Console.WriteLine(i + "\t" + array[i - 1] + "\t" + array[i] + "\t" + max);
            }
            Console.WriteLine("Max = " + max);
        }
    }
}
