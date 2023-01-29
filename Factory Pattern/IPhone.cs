using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Factory_Pattern
{
    public class IPhone : Phone
    {
        public IPhone()
        {
            this.Make();
        }

        public void Make()
        {
            Console.WriteLine("Make Apple Phone");
        }
    }
}
