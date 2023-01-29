using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Method_Shadowing_or_Hiding
{
    class Class1
    {
        public class Parent
        {
            public string Display()
            {
                return "Parent Class!";
            }
        }

        public class Child : Parent
        {
            public new string Display()
            {
                return "Child Class!";
            }
        }

        //static void Main(String[] args)
        //{
        //    Child child = new Child();
        //    Console.WriteLine(child.Display());
        //}
    }
}
