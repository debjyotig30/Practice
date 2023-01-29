using System;
using System.Collections;
using System.Collections.Generic;

namespace DirectExcute
{
	public class Program
	{
		public static void Main(string[] args)
		{
			//Class3 class3 = new Class3();
			//Class1 class1 = new Class1();

			//class1 = class3;

			//class1.Show();
			//class3.Show();

			Program p = new Program();

			Class1 ob = new Class1();

			ob.TestforExtensionMethodInOrigClass("qwertyui");
			ob.MyExtensionMethod();
   
				//p.ChekPerfect(5);

				//int myDict = p.CountDuplicate("sstcc");

				//string op = p.CheckPerfectNumber(23);
				//Console.WriteLine(op);
		}

		private string RemoveDuplicate(string str)
		{
			string newStr = "";

			foreach(char c in str)
			{
				if(!newStr.Contains(c))
				{
					newStr += c;
				}
			}

			return newStr;
		}

		private string ReturnDuplicate(string str)
		{
			string newStr = "";
			string dupStr = "";

			foreach (char c in str)
			{
				if (!newStr.Contains(c))
				{
					newStr += c;
				}
				else
				{
					dupStr += c;
				}
			}

			return dupStr;
		}

		private int CountDuplicate(string str)
		{
			string newStr = "";
			string dupStr = "";
			int noOfDuplicates = 0;

			foreach (char c in str)
			{
				if (!newStr.Contains(c))
				{
					newStr += c;
				}
				else
				{
					dupStr += c;
					noOfDuplicates++;
				}
			}

			return noOfDuplicates;
		}

		private Dictionary<char, int> CountOccurenceofEachCharInString(string input)
		{
			Dictionary<char, int> myDict = new Dictionary<char, int>();

			foreach(char c in input)
			{
				int count = 0;

				if(myDict.ContainsKey(c))
				{
					count = myDict[c];
				}
				myDict[c] = count + 1;
			}

			foreach(KeyValuePair<char, int>pair in myDict)
			{
				Console.WriteLine(pair.Key + "=" + pair.Value);
			}

			return myDict;
		}

		private string CheckPerfectNumber(int N)
		{
			int[] arr = new int[10];
			int j = 0;

			for (int i = 1; i <= N/2; i++)
			{
				if (N % i == 0)
				{
					arr[j] = i;
					j++;
				}
			}

			int sum = 0;

			for (int i = 0; i < arr.Length; i++)
			{
				sum += arr[i];
			}
			if (sum == N)
			{
				return "YES";
			}
			return "NO";
		}


		private void ChekPerfect(int A)
		{
			while (A-- > 0)
			{
				int N = Int32.Parse(Console.ReadLine());

				int[] arr = new int[10];
				int j = 0;

				for (int i = 1; i <= N / 2; i++)
				{
					if (N % i == 0)
					{
						arr[j] = i;
						j++;
					}

					int sum = 0;

					for (int k = 0; k < arr.Length; k++)
					{
						sum += arr[k];
					}

					if (sum == N)
					{
						System.Console.WriteLine("YES");
					}
					System.Console.WriteLine("NO");
				}
			}
		}
	}
}
