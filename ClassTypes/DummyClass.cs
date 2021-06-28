using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.ClassTypes
{
    class DummyClass : IDisposable
    {
        public DummyClass()
        {
            System.Console.WriteLine("Creating Dummy Class");
        }

        public void Dispose()
        {
            System.Console.WriteLine("Dispose Called");
        }

        public void dummyMethod()
        {
            System.Console.WriteLine("Dummy Method");
        }
    }


}
