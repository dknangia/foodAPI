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
        public IList<FoodModel> GetFood()
        {
            return DB.foodList;
        }

        public FoodModel GetFood(int foodId)
        {
            if(foodId < 0)
            {
                throw new Exception("Passed foodId cannot be less than 0"); 
            }

            return DB.foodList.Find(x => x.ID == foodId);
        }

        
        public virtual FoodModel SaveFood(FoodModel toSave)
        {
            int newId = DB.foodList.Count  +1 ;
            toSave.ID = newId; 
            DB.foodList.Add(toSave);
            return DB.foodList.Find(x => x.ID == newId);

        }

        public void UpdateFood(FoodModel toUpdate)
        {
            throw new NotImplementedException();
        }

        public int addPositiveUnmbers(int a, int b)
        {
            try
            {
                if ((a < 0 || b < 0))
                {
                    return -1;
                }

                return a + b;
            }
            catch (Exception ex)
            {
                throw;
            }
            
        }
    }
}