using ConsoleApp_OrderService.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_OrderService.Service
{
    public class Food2Service :IFoodService
    {
        public string MainMeal()
        {
            return "fried chicken";
        }

        public string Dessert()
        {
            return "icecream";
        }

        public string Drinks()
        {
            return "black tea";
        }
    }
}
