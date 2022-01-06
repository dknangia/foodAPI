using System;

namespace Food.Models
{
    public class DiaryModel
    {
        public int Id { get; set; }
        public FoodModel FoodEntry { get; set; }
        public DateTime CurrentDate { get; set; }
        public string UserName { get; set; }
    }
}