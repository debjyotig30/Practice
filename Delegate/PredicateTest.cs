using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Delegate
{
    class PredicateTest : IPractice
    {
        public static bool IsUpperCase(string str)
        {
            return str.Equals(str.ToUpper());
        }
        public void execute()
        {
            //Predicate delegate
            Predicate<string> isUpper1 = IsUpperCase;
            bool result1 = isUpper1("TY");
            Console.WriteLine(result1);

            //Predicate delegate with anonymous method
            Predicate<string> isUpper2 = delegate (string s) { return s.Equals(s.ToUpper()); };
            bool result2 = isUpper2("Ty");
            Console.WriteLine(result2);

            //Predicate delegate with lambda expresion
            Predicate<string> isUpper3 = s => s.Equals(s.ToUpper());
            bool result3 = isUpper3("TY");
            Console.WriteLine(result3);
        }
    }
}
