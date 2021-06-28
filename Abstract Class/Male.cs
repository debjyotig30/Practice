using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Abstract_Class
{
    class Male: AHuman
    {
        public override void getGender()
        {
            Console.WriteLine("Male");
        }

        //Male string speak()
        //{
        //    return "I am a Man.";
        //}
        public override void execute()
        {
            Console.WriteLine("This execute is within Male.");
        }

    }
}
