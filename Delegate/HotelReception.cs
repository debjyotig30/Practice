using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Delegate
{
    public class HotelReception : IPractice
    {
        private Action LaundryAction;
        private Action KitchenAction;
        private HotelKitchen Kitchen;

        public HotelReception()
        {
            //LaundryAction = new Action(HotelLaundry.CleanClothes);
            LaundryAction = delegate ()
            {
                Console.WriteLine("Cleaned your clothes"); //This is an anonymous function.
            };
            LaundryAction += delegate ()
            {
                Console.WriteLine("Folded Your clothes");
            };
            Kitchen = new HotelKitchen();
            KitchenAction = new Action(Kitchen.cookMeal);
        }

        public void chekinGuest( HotelGuest hotelGuest) 
        {
            Console.WriteLine("Welcome to our hotel, Mr. " + hotelGuest.Name);
            hotelGuest.CheckClothes(LaundryAction);
            //hotelGuest.CheckClothes(delegate ()
            //{
            //    Console.WriteLine("Cleaned your clothes");
            //});
            hotelGuest.ArrangeMeal(KitchenAction);
        }

        public void changeMenu()
        {
            Kitchen.FoodItem = "Biryani";
        }

        public void execute()
        {
            HotelReception hotelReception = new HotelReception();
            
            // Day 1

            HotelGuest debjyoti = new HotelGuest("Debjyoti");
            debjyoti.CleanClothes = false;
            debjyoti.Hungry = true;

            hotelReception.chekinGuest(debjyoti);

            // Day 2
            hotelReception.changeMenu();
            
            HotelGuest devraj = new HotelGuest("Devraj");
            devraj.CleanClothes = true;
            devraj.Hungry = true;
            hotelReception.chekinGuest(devraj);
        }
    }
}
