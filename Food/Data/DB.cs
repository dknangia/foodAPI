using Food.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Routing;

namespace Food.Data
{
    public class Db
    {
        public static List<FoodModel> FoodList = null;
        
        public Db()
        {
            
            if (FoodList == null)
            {
                FoodList = new List<FoodModel>();
                Get();
            }
        }

        List<FoodModel> Get()
        {
            FoodList.Add(new FoodModel { Id = 1, Name = "Bread", Price = 1d  }) ;
            FoodList.Add(new FoodModel { Id = 2, Name = "Rice", Price = 1.5d });
            FoodList.Add(new FoodModel { Id = 3, Name = "Boiled Potato", Price = 0.80d });
            FoodList.Add(new FoodModel { Id = 4, Name = "Pasta", Price = 5.69d });
            FoodList.Add(new FoodModel { Id = 5, Name = "Cheese pasta", Price = 14.0d });
            FoodList.Add(new FoodModel { Id = 6, Name = "Butter Bread", Price = 2.96d });
            FoodList.Add(new FoodModel { Id = 7, Name = "Chocolate milk", Price = 7.84d });
            FoodList.Add(new FoodModel { Id = 8, Name = "Salad", Price = 6.36d });

            return FoodList;
        }
    }
}