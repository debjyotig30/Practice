using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Utilities
    {
        public static int[] ReadArrayInputfromUser()
        {
            Console.Write("Enter the length of array: ");
            int arrayLength = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the values of array:");
            int[] array = new int[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            return array;
        }

        public static void PrintArray(int[] inputArray)
        {
            int arraylength = inputArray.Length;
            Console.WriteLine("The array is:");
            for (int i = 0; i < arraylength; i++)
            {
                Console.Write(inputArray[i] + " ");
            }
            Console.WriteLine("");
        }

        public static int[] SortArrayDescending(int[] inputArray)
        {
            int temp;

            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                for (int j = i + 1; j < inputArray.Length; j++)
                {
                    if (inputArray[i] < inputArray[j])
                    {
                        temp = inputArray[i];
                        inputArray[i] = inputArray[j];
                        inputArray[j] = temp;
                    }
                }
            }
            Console.WriteLine("Descending:");
            Utilities.PrintArray(inputArray);
            return inputArray;
        }

        public static int[] SortArrayAscending(int[] inputArray)
        {
            int temp;

            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                for (int j = i + 1; j < inputArray.Length; j++)
                {
                    if (inputArray[i] > inputArray[j])
                    {
                        temp = inputArray[i];
                        inputArray[i] = inputArray[j];
                        inputArray[j] = temp;
                    }
                }
            }
            Console.WriteLine("Ascending:");
            Utilities.PrintArray(inputArray);
            return inputArray;
        }
    }
}

