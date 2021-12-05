using Food.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Routing;

namespace Food.Data
{
    public class DB
    {
        public static List<FoodModel> foodList = null;
        
        public DB()
        {
            
            if (foodList == null)
            {
                foodList = new List<FoodModel>();
                Get();
            }
        }

        List<FoodModel> Get()
        {
            foodList.Add(new FoodModel { id = 1, Name = "Bread", Price = 1d  }) ;
            foodList.Add(new FoodModel { id = 2, Name = "Rice", Price = 1.5d });
            foodList.Add(new FoodModel { id = 3, Name = "Boiled Potato", Price = 0.80d });
            foodList.Add(new FoodModel { id = 4, Name = "Pasta", Price = 5.69d });
            foodList.Add(new FoodModel { id = 5, Name = "Cheese pasta", Price = 14.0d });
            foodList.Add(new FoodModel { id = 6, Name = "Butter Bread", Price = 2.96d });
            foodList.Add(new FoodModel { id = 7, Name = "Chocolate milk", Price = 7.84d });
            foodList.Add(new FoodModel { id = 8, Name = "Salad", Price = 6.36d });

            return foodList;
        }
    }
}