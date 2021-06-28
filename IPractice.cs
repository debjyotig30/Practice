using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    interface IPractice
    {
        public void execute();
        public string print()
        {
            return "String";
        }
    }
}
