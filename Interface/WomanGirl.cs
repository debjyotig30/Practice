using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Interface
{
    class WomanGirl : IHuman
    {
        public void execute()
        {
            Console.WriteLine("This execute is in WomanGirl.");
        }

        public string getGender()
        {
            Console.WriteLine("Female");
            return "Female";
        }
    }
}
