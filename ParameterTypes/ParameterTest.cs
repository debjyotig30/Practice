using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.ParameterTypes
{
    class ParameterTest : IPractice
    {
        public void InTest(in int x) // We cannot change the value of 
        {
            int y = x;
            y = x + 1;
            Console.WriteLine("Running InTest");
            Console.WriteLine("x = " + x);
            //x = x + 1;
        }
        public void OutTest(out int x)
        {
            Console.WriteLine("Running OutTest");
            // x++; // not possible.
            Console.Write("Enter a value for x: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("x = " + x);
        }
        public void RefTest(ref int x)
        {
            Console.WriteLine("Running RefTest");
            x++;
            Console.WriteLine("x = " + x);
            x = x + 1;
        }

        public void NormalTest(int x)
        {
            Console.WriteLine("Running NormalTest");
            x++;
            Console.WriteLine("x = " + x);
            x = x + 1;
        }

        public void NormalTestObj(Student student)
        {
            Console.WriteLine("Running NormalTestObj");
            student.Marks++;
            Console.WriteLine("student.Marks = " + student.Marks);//89
        }

        public void RefTestObj(ref Student student)
        {
            Console.WriteLine("Running RefTestObj");
            student.Marks++;
            Console.WriteLine("student.Marks = " + student.Marks);//90
        }
        public void NormalTestObjUpdated(Student student)
        {
            Console.WriteLine("Running NormalTestObjUpdated");
            Console.WriteLine("NormalTestObjUpdated - student.Name = " + student.Name);//Ram
            Student nayaBachha = new Student();
            nayaBachha.Name = "Shyam";
            nayaBachha.Marks = 99;
            student = nayaBachha;
            Console.WriteLine("NormalTestObjUpdated - student.Name = " + student.Name);//Shyam
        }

        public void RefTestObjUpdated(ref Student student)
        {
            Console.WriteLine("Running RefTestObjUpdated");
            Console.WriteLine("RefTestObjUpdated - student.Name = " + student.Name);//Ram
            Student nayaBachha = new Student();
            nayaBachha.Name = "Shyam";
            nayaBachha.Marks = 99;
            student = nayaBachha;
            Console.WriteLine("RefTestObjUpdated - student.Name = " + student.Name);//Shyam
        }

        public void InOutRefMethod(in int inParam, out int outParam, ref int refParam, int param)
        {
            //inParam = 1;    // Not possible.
            int var1 = inParam + 2; //We can use the data stored in inParam but cannot change it.
            outParam = inParam + var1;  // We must assign a value to the outParam in the function.
            //refParam += 1;
            outParam = inParam + outParam + refParam;

            //refParam = outParam;
        }

        public void calc(in int num1, in int num2, out int sum, out int diff, out int prod)
        {
            sum = num1 + num2;
            diff = num1 - num2;
            prod = num1 * num2;
        }

        public void execute()
        {
            //int input = 10;
            //Console.WriteLine("input = " + input);
            //InTest(in input);

            //Console.WriteLine("input = " + input);
            //OutTest(out input);
            //Console.WriteLine("input = " + input);
            //RefTest(ref input);
            //Console.WriteLine("input = " + input);
            //NormalTest(input);
            //Console.WriteLine("input = " + input);
            //Console.WriteLine("-----------------------------");
            Student stud = new Student();
            stud.Name = "Ram";
            stud.Marks = 88;


            


            Console.WriteLine("student.Marks = " + stud.Marks);//88
            NormalTestObj(stud);
            Console.WriteLine("student.Marks = " + stud.Marks);//89
            RefTestObj(ref stud);
            Console.WriteLine("student.Marks = " + stud.Marks);//90
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Outside - student.Name = " + stud.Name);//Ram
            NormalTestObjUpdated(stud);
            Console.WriteLine("Outside - student.Name = " + stud.Name);//Ram
            RefTestObjUpdated(ref stud);
            Console.WriteLine("Outside - student.Name = " + stud.Name);//Shyam
            //int inParam = 1;
            ////int outParam = 2; We cannot declare/define the out parameter outside the function which uses it.
            //int refParam = 3;
            //int param = 4;
            //InOutRefMethod(in inParam, out int outParam, ref refParam, param);
            //int num1 = 3;
            //int num2 = 2;
            //calc(in num1, in num2, out int sum, out int diff, out int prod);
            //Console.WriteLine(sum);
            //Console.WriteLine(diff);
            //Console.WriteLine(prod);
        }
    }
}

//in parameter is used only to pass a parameter to a function. We can then use the value of that parameter in the fn. but cannot change its value within the function.

//out  parameter is used when a method returns multiple values.
//When a parameter is passed with the Out keyword in a method, then that method works with the same variable value that is passed in the method call.
//If the variable value changes, the method parameter value also changes.
//Variables passed as out arguments do not have to be initialized before being passed in a method call. However, the called method is required to assign a value before the method returns.
