using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.ClassTypes
{

    //Static classes are sealed class and therefore, cannot be inherited.
    public static class StaticClass // : IPractice -- Static classes cannot implement interfaces or inherit other class.
    {
        public static int StaticClassvar1;
        private static int StaticClassvar2;
        //int var1; Not possible. // All members in a static class must be static;
        public static void method1() // All members in a static class must be static;
        {
            StaticClassvar1 = 1;
            StaticClassvar2 = 2;
            Console.WriteLine("Inside public static");
        }

        private static void method2()
        {
            StaticClassvar1 = 1;
            StaticClassvar2 = 2;
            Console.WriteLine("Inside private static");
            StaticClass.method1(); //Static class members can be accessed only using ClassName.MemberName
            StaticClassTester.StaticClassTestervar3 = 99; //Static classes can access only static members from non-static classes.
        }

        //StaticClass sc = new StaticClass(); //Static classes cannot be instantiated.

        // StaticClass()
        //{
                //Static classes cannot have constructors.
        //}


    }
}
