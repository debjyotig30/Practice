using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.ClassTypes
{
    class SimplifiedClass : IPractice
    {
        private ComplicatedClass complicatedClass;
        SimplifiedClass(ComplicatedClass complicatedClass)
        {
            this.complicatedClass = complicatedClass;
        }
        public int secondCalc(int hours)
        {
            int minute = complicatedClass.MinuteCalc(hours);

            int seconds = 60 * minute;
            Console.WriteLine("Seconds: " + seconds);
            return seconds;
        }
       

        //WrapperClass.InnerClass wcIc = new WrapperClass.InnerClass();        

        public void execute()
        {
            int hours = 1;
            Console.WriteLine("Hours: " + hours);
            ComplicatedClass complicatedClass = new ComplicatedClass();
            SimplifiedClass wcSecCalc = new SimplifiedClass(complicatedClass);
            wcSecCalc.secondCalc(hours);
        }
    }
    class ComplicatedClass
    {
        public int MinuteCalc(int hours)
        {
            int minutes = 60 * hours;
            Console.WriteLine("Minutes: " + minutes);
            return minutes;

        }
    }
}


