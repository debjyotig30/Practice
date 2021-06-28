using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Interface
{
    interface IHuman  : IPractice  //Interfaces cannot inherit an abstract class.
    {
        public string getSpecies()
        {
            Console.WriteLine("HomoSapiens");
            return "Homo-Sapiens";
        }

        public abstract string getGender();

        //IHuman ih = new IHuman(); Interfaces can not be instantiated.
    }
}
