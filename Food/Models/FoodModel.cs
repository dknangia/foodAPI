using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Food.Models
{
    public class FoodModel
    {
        public string Url { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }        
    }
}