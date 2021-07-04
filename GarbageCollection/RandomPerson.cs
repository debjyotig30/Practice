using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.GarbageCollection
{
    public class RandomPerson : IDisposable
    {
        public string Name { get; set; }
        public RandomPerson()
        {
            Name = "Birth Name";
            Console.WriteLine("RandomPerson was born...");
        }

        public void PrintName()
        {
            Console.WriteLine("My name is " + Name);
        }

        public void Dispose()
        {
            Console.WriteLine("RandomPerson with name - " + Name + " was killed.");
            
        }

        ~RandomPerson() //Destructor or Finalizer
        {
            Console.WriteLine("RandomPerson with name - " + Name + " died.");
        }
        
    }
}
