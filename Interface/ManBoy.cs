using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Interface
{
    class ManBoy : IHuman
    {
        public void execute()
        {
            Console.WriteLine("This execute is in ManBoy.");
        }

        public string  getGender()
        {
            Console.WriteLine("Male");
            return "Male";
        }
    }
}
