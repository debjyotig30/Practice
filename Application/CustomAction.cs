using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Application
{
    public class CustomAction : IAction
    {
        private void CreateClock()
        {
            Console.WriteLine("Created a clock.");
        }

        public void StartActivity()
        {
            //base.StartActivity();
            CreateClock();
            Console.WriteLine("Attached the clock to the window.");
        }
    }
}
