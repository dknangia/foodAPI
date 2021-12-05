using Food.Data;
using System;
using System.Collections.Generic;
using System.Web.Http.Routing;

namespace Food.Models.Repository
{
    public class FoodRepository : IFoodRepository
    {
        private DB _db;

        public FoodRepository()
        {
            _db = new DB();
        }
        public IEnumerable<FoodModel> GetFood()
        {
            return DB.foodList;
        }

        public FoodModel GetFood(int foodId)
        {
            try
            {
                if(foodId < 0)
                {
                    throw new Exception("Passed foodId cannot be less than 0"); 
                }
            }
            catch (Exception ex)
            {

                 throw ex;
            }

            return DB.foodList.Find(x => x.id == foodId);
        }

        public FoodModel SaveFood(FoodModel toSave)
        {
            int newId = DB.foodList.Count  +1 ;
            toSave.id = newId; 
            DB.foodList.Add(toSave);
            return DB.foodList.Find(x => x.id == newId);

        }

        public void UpdateFood(FoodModel toUpdate)
        {
            throw new NotImplementedException();
        }
    }
}