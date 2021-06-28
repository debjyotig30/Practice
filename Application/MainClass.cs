using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Application
{
    public class MainClass : IPractice
    {
        public void execute()
        {
            IAction customAction = new CustomAction();

            MyProgram myProgram = new MyProgram(customAction);
            myProgram.StartProgram();
        }
    }
}
