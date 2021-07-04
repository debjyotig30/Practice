using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Delegate
{
    public class HotelGuest
    {
        public string Name { get; }
        public bool CleanClothes { get; set; }
        public bool Hungry { get; set; }

        public HotelGuest(string name)
        {
            Name = name;
        }

        public void CheckClothes(Action doLaundry)
        {
            if (CleanClothes)
                Console.WriteLine("No need to clean clothes.");
            else
                doLaundry();
        }
        public void ArrangeMeal(Action cook)
        {
            if (Hungry)
                cook();
            else
                Console.WriteLine("I am not hungry");
        }
    }
}
