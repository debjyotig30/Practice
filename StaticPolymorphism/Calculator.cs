using Practice.Abstract_Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.StaticPolymorphism
{
    class Calculator : IPractice
    {
        public void execute()
        {
            Console.WriteLine("Execute in calculator.");
            Calculator calculator = new Calculator();
            calculator.Sum(1,2);
            calculator.Sum(1, 2);
            calculator.Sum(1.1f, 1.2f);
            calculator.Sum(1.2f, 1);
            calculator.Sum(1, 1.1f);

            Male customObjM = new Male();
            Female customObjF = new Female();
            calculator.ObjectOperation(customObjM, customObjF);
        }

        public void Sum(int input1, int input2)
        {
            int sum = input1 + input2;
            Console.WriteLine("Sum = " + sum);
        }

        public void Sum(float input1, float input2)
        {
            float sum = input1 + input2;
            Console.WriteLine("Sum = " + sum);
        }

        public void Sum(int input1, float input2)
        {
            float sum = input1 + input2;
            Console.WriteLine("Sum = " + sum);
        }

        public void ObjectOperation(Male objMale, Female objFemale)
        {
            objMale.getGender();
            objFemale.getGender();
        }

        public void ObjectOperation(AHuman objMale, AHuman objFemale)
        {
            objMale.getGender();
            objFemale.getGender();
        }
    }
}
