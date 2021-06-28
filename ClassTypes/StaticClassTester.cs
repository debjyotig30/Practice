using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.ClassTypes
{
    class StaticClassTester : IPractice
    {
        private static int StaticClassTestervar1;
        private int StaticClassTestervar2;

        public static int StaticClassTestervar3;
        public int StaticClassTestervar4;

        static StaticClassTester()
        {
        }

        public void  StaticClassTesterMethod()
        {
            StaticClassTestervar1 = 11;
            StaticClassTestervar2 = 12;
            StaticClassTester.StaticClassTesterStaticMethod();
        }

        public static void StaticClassTesterStaticMethod()
        {
            StaticClassTestervar1 = 10; //Static classes can access/call only other static members.
            
            StaticClassTester staticClassTesterObj = new StaticClassTester();
            staticClassTesterObj.StaticClassTesterMethod();

            StaticClass.StaticClassvar1 = 0;
        }

        public void execute()
        {
            StaticClassTester staticClassTesterObj = new StaticClassTester();
            staticClassTesterObj.StaticClassTesterMethod();

            StaticClassTester.StaticClassTesterStaticMethod(); //Static methods in non-static classes also have to be called using ClassName.
        }


    }
}


//STATIC CAN ONLY CALL STATIC (EVEN WITHIN SAME CLASS).
//STATIC CANNOT CALL NON-STATIC.
//