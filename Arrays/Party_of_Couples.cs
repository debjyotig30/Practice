using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Arrays
{
    class Party_of_Couples : IPractice
    {
        public int FindSingle(int N, int[] arr)
        {
            // code here
            int ans = 0;
            bool[] boolArr = new bool[N];

            for (int i = 0; i < N; i++)
            {
                boolArr[i] = true;
                bool found = false;

                for (int j = i + 1; j < N; j++)
                {
                    if (arr[i] == arr[j] && boolArr[j] != true)
                    {
                        boolArr[j] = true;
                        found = true;
                        break;
                    }

                }
                if (!found)
                {
                    ans = arr[i];
                    Console.WriteLine(ans);
                    return ans;
                }
            }
            Console.WriteLine("Not found");
            return 0;
        }

        public int isDigitSumPalindrome(int N)
        {
            // code here
            int input = N;
            int remainder = 0;
            int number = 0;
            int sum = 0;

            Party_of_Couples sol = new Party_of_Couples();

            if (sol.FindSumofDigits(input) == sol.ReverseNumber(input))
            //if(sum == number)
            {
            //    Console.WriteLine("Sum: " + sum);
            //    Console.WriteLine("Rev: " + number);
                Console.WriteLine("1");
                return 1;
            }
            else
            {
                //Console.WriteLine("Sum: " + sum);
                //Console.WriteLine("Rev: " + number);
                Console.WriteLine("0");
                return 0;
            }
        }

        public int FindSumofDigits(int N)
        {
            int input = N;
            int sum = 0;
            int remainder = 0;
            while (input > 0)
            {
                remainder = input % 10;
                sum += remainder;
                input = input / 10;
            }
            //Console.WriteLine("Sum: " + sum);
            return sum;
        }

        public int ReverseNumber(int N)
        {
            int input = N;
            int number = 0;
            int remainder = 0;
            int sum = FindSumofDigits(N);
            while (sum > 0)
            {
                //Console.WriteLine("Sum: " + sum);
                remainder = sum % 10;
                number = (number * 10) + remainder;
                sum = sum / 10;
                //Console.WriteLine("Sum: " + sum);
            }
            //Console.WriteLine("Sum: " + sum);
            //Console.WriteLine("Rev: " + number);
            return number;
        }
        public void execute()
        {
            Party_of_Couples poc = new Party_of_Couples();
            int N = 7;
            int[] arr0 = { 1,2,3,4,5,6,7 };
            int[] arr1 = { 1,1,0,0,2,2,3 };
            int[] arr2 = { 1,2,3,0,3,2,1 };
            int[] arr3 = { 1,1,2,2,3,3,3 };

            //poc.FindSingle(N, arr3);
            poc.isDigitSumPalindrome(56);
        }
    }
}
