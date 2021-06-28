using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Application
{
    public class MyProgram
    {
        private IAction action;

        public MyProgram(IAction action)
        {
            this.action = action;
        }
        public void StartProgram()
        {
            action.StartActivity();
        }
        
    }
}
