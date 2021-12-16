using System;

namespace Food.Models
{
    public class DiaryModel
    {
        public int ID { get; set; }
        public FoodModel FoodEntry { get; set; }
        public DateTime currentDate { get; set; }
        public string UserName { get; set; }
    }
}