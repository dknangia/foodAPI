using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Food.Models.Repository
{
    public interface IFoodRepository
    {
        IList<FoodModel> GetFood();
        FoodModel GetFood(int foodId);

        FoodModel SaveFood(FoodModel toSave);

        void UpdateFood(FoodModel toUpdate); 
    }
}