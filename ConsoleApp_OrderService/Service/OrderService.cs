using ConsoleApp_OrderService.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_OrderService
{
    public class OrderService
    {
        private readonly IFoodService _foodService;

        public IFoodService Food3Service { get; set; }

        /// <summary>
        /// 建構子 Constructor
        /// </summary>
        public OrderService()
        { }

        /// <summary>
        /// 建構子 Constructor
        /// </summary>
        /// <param name="foodService"></param>
        public OrderService(IFoodService foodService)
        {
            _foodService = foodService;
        }

        public void ConstructorRun()
        {
            Console.WriteLine(_foodService.MainMeal());
            Console.WriteLine(_foodService.Dessert());
            Console.WriteLine(_foodService.Drinks());
        }

        public void PropertyRun()
        {
            Console.WriteLine(Food3Service.MainMeal());
            Console.WriteLine(Food3Service.Dessert());
            Console.WriteLine(Food3Service.Drinks());
        }

        public void MethodRun(IFoodService foodService)
        {
            Console.WriteLine(foodService.MainMeal());
            Console.WriteLine(foodService.Dessert());
            Console.WriteLine(foodService.Drinks());
        }
    }
}