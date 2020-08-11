using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_OrderService
{
    public class FoodService : Service.Interface.IFoodService
    {
        public string MainMeal()
        {
            return "hamburger";
        }

        public string Dessert()
        {
            return "icecream";
        }

        public string Drinks()
        {
            return "cola";
        }
    }
}