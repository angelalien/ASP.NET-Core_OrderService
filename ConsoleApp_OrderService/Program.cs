using ConsoleApp_OrderService.Service;
using ConsoleApp_OrderService.Service.Interface;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ConsoleApp_OrderService
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 建立依賴注入的容器
            var service = new ServiceCollection();
            // 2 註冊服務
            service.AddSingleton<IFoodService, FoodService>();
            // 建立相依服務提供者
            var runner = service.BuildServiceProvider().GetRequiredService<IFoodService>();

            Console.WriteLine(runner.MainMeal());
            Console.WriteLine(runner.Dessert());
            Console.WriteLine(runner.Drinks());

            Console.WriteLine("====================建構子注入====================");

            // 建構子注入
            var orderService1 = new OrderService(new Food2Service());
            orderService1.ConstructorRun();

            Console.WriteLine("====================屬性注入====================");

            // 屬性注入
            var orderService2 = new OrderService();
            orderService2.Food3Service = new Food3Service();
            orderService2.PropertyRun();

            Console.WriteLine("====================方法注入====================");

            // 方法注入
            var orderService3 = new OrderService();
            orderService3.MethodRun(new FoodService());

            Console.ReadLine();
        }
    }
}
