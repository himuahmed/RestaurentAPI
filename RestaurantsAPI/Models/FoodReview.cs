using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantsAPI.Models
{
    public class FoodReview
    {
        public int Id { get; set; }
        public ItemModel Item { get; set; }
        public int Price { get; set; }
        public double Rating { get; set; }
        public string Description { get; set; }
        public bool IsOffered { get; set; }
        public int Consumable { get; set; }
        public bool IsRecommended { get; set; }
        public List<TagModel> FoodTags { get; set; }

    }
}
