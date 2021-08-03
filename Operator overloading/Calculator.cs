using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Operator_overloading
{
    class Calculator : IPractice
    {
        public int number = 0;

        public Calculator() { }

        public Calculator(int n)    // parameterized constructor
        {
            number = n;
        }

        // Overloading of Binary "+" operator
        public static Calculator operator +(Calculator Calc1, Calculator Calc2)
        {
            Calculator Calc3 = new Calculator(0);
            Calc3.number = Calc2.number + Calc1.number;
            return Calc3;
        }

        public static Calculator operator -(Calculator Calc1, Calculator Calc2)
        {
            Calculator Calc3 = new Calculator();
            Calc3.number = Calc1.number - Calc2.number;
            return Calc3;
        }

        // function to display result
        public void display()
        {
            Console.WriteLine("{0}", number);
        }

        public void execute()
        {
            Calculator num1 = new Calculator(200);
            Calculator num2 = new Calculator(40);
            Calculator num3 = new Calculator();


            num3 = num1 - num2;

            num1.display(); // Displays 200

            num2.display(); // Displays 40

            num3.display(); // Displays 240
        }
    }
}
