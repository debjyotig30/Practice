using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Generics
{
    class GenericsTester<TYPE> : IPractice
    {

        public bool Compare(int x, int y)
        {
            if (x == y)
            {
                Console.WriteLine("True");
                return true;
            }
            else
            {
                Console.WriteLine("False");
                return false;
            }
        }

        public bool Compare(TYPE x, TYPE y)
        {
            if (x.Equals(y))
            {
                Console.WriteLine("True");
                return true;
            }
            else
            {
                Console.WriteLine("False");
                return false;
            }
        }

        public void execute()
        {
            //GenericsTester genObj = new GenericsTester();
            int x = 1;
            int y = 2;
            //genObj.Compare(x, y);

            GenericsTester<int> genObj = new GenericsTester<int>();
            bool reslt = genObj.Compare(x,y);
        }
    }
}
