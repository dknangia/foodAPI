using Food.Data;
using System;
using System.Collections.Generic;
using System.Web.Http.Routing;

namespace Food.Models.Repository
{
    public class FoodRepository : IFoodRepository
    {
        private Db _db;

        public FoodRepository()
        {
            _db = new Db();
        }
        public IList<FoodModel> GetFood()
        {
            return Db.FoodList;
        }

        public FoodModel GetFood(int foodId)
        {
            if(foodId < 0)
            {
                throw new Exception("Passed foodId cannot be less than 0"); 
            }

            return Db.FoodList.Find(x => x.Id == foodId);
        }

        
        public virtual FoodModel SaveFood(FoodModel toSave)
        {
            if (toSave != null)
            {
                int newId = Db.FoodList.Count + 1;
                toSave.Id = newId;
                Db.FoodList.Add(toSave);
                return Db.FoodList.Find(x => x.Id == newId);
            }
            else
            {
                throw new ArgumentNullException(paramName: "SaveFood() : toSave cannot be null");
            }

        }

        public void UpdateFood(FoodModel toUpdate)
        {
            throw new NotImplementedException();
        }

        public int AddPositiveNumbers(int a, int b)
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

        public string GetOutput(int number)
        {
            if ((number % 3 == 0) && (number % 5 == 0))
                return "FizzBuzz"; 
            else if (number % 3 == 0)
            {
                return "Fizz";
            }else if (number % 5 ==0 )
            {
                return "Buzz"; 
            }
            else
            {
                return number.ToString();
            }
        }
    }
}