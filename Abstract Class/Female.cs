using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Abstract_Class
{
    class Female : AHuman
    {
        public override void getGender()
        {
            Console.WriteLine("Female");
        }

        //Female string speak()
        //{
        //    return "I am not a Man.";
        //}
        public override void execute()
        {
            Console.WriteLine("This execute is within  woman.");
        }
    }
}
