using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_OrderService.Service.Interface
{
    public interface IFoodService
    {
        /// <summary>
        /// 主餐
        /// </summary>
        /// <returns></returns>
        string MainMeal();

        /// <summary>
        /// 附餐
        /// </summary>
        /// <returns></returns>
        string Dessert();

        /// <summary>
        /// 飲料
        /// </summary>
        /// <returns></returns>
        string Drinks();
    }
}
