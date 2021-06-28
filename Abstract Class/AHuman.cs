using Practice.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Abstract_Class
{
    //abstract class AHuman : IHuman
    abstract class AHuman : IPractice
    {
        public abstract void getGender();

        public void getSpecies()
        {
            Console.WriteLine("HomoSapiens");
        }

        public virtual void execute()
        {
            //throw new NotImplementedException();
            Console.WriteLine("This execute is within AHuman.");
        }
    }
}
