using System;
using System.Collections.Generic;
using System.Text;

namespace DirectExcute
{
    public static class MyExtension
    {
        public static string MyExtensionMethod(this Class1 otherInput)
        {
            Console.WriteLine(otherInput + " Added_In_Extension_Class");
            return " Added_In_Extension_Class";
        }
    }
}
