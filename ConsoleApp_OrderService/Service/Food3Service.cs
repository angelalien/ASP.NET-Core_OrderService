using ConsoleApp_OrderService.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_OrderService.Service
{
    public class Food3Service : IFoodService
    {
        public string MainMeal()
        {
            return "pizza";
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