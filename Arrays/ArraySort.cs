using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Arrays
{
    public class ArraySort: IPractice
    {
        public int[] BubbleSort(int[] inputArray)
        {

            for (int j = 0; j <= inputArray.Length - 2; j++)
            {
                for (int i = j+1; i < inputArray.Length; i++)
                {
                    if (inputArray[i] < inputArray[j])
                    {
                        int temp = inputArray[j];
                        inputArray[j] = inputArray[i];
                        inputArray[i] = temp;
                    }
                }
            }
            return inputArray;
        }

        public void FindArrayInArray(int[] largerArray, int[] smallerArray)
        {
            int ctr = 0;

            for(int i=0; i< smallerArray.Length; i++)
            {
                for(int j=0; j< largerArray.Length; j++)
                {
                    if(largerArray[j] == smallerArray[i])
                    {
                        ctr++;
                    }
                }
            }
            if (ctr == smallerArray.Length)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            
        }

        public bool FindTriplets(int[] arr, int n)
        {            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    for (int k = 0; k < j; k++)
                    {
                        if ((arr[i] + arr[j] + arr[k]) == 1)
                        {
                            Console.WriteLine("True");
                            return true;
                        }
                    }
                }
            }
            Console.WriteLine("False");
            return false;
        }

        public void execute()
        {
            ArraySort asObj = new ArraySort();
            int[] arr = {0,1,2,3};
            int n = 4;

            asObj.FindTriplets(arr, n);

            return;

            int[] largerArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] smallerArray = {  9 };

            asObj.FindArrayInArray(largerArray, smallerArray);
            
            return;

            int[] inputArray = { 1, 9, 2, 8, 3, 7, 5, 6 };
            int[] myarr = asObj.BubbleSort(inputArray);
            Utilities.PrintArray(myarr);
        }
    }
}
