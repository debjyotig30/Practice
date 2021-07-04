using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Delegate
{
    public class HotelKitchen
    {
        public HotelKitchen()
        {
            FoodItem = "Paratha";
        }
        public string FoodItem { get; set; }

        public void cookMeal()
        {
            Console.WriteLine("We have prepared for you: " + FoodItem);
        }
    }
}
