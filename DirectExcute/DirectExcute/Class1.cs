using System;
using System.Collections.Generic;
using System.Text;

namespace DirectExcute
{
    public class Class1
    {
        public string customInput;
        public virtual void Show()
        {
            Console.WriteLine("1.Show()");
        }

        public string TestforExtensionMethodInOrigClass(string input)
        {
            Console.WriteLine(input + " addedThis");
            return input + " addedThis";
        }
    }
}
