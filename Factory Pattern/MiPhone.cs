using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Factory_Pattern
{
    public class MiPhone : Phone
    {
        public MiPhone()
        {
            this.Make();
        }

        public void Make()
        {
            Console.WriteLine("Make Xiaomi phone");
        }
    }
}
