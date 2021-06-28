using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Application

{
    public abstract class Action
    {
        public virtual void StartActivity()
        {
            Console.WriteLine("Displayed a window.");
        }
    }
}
