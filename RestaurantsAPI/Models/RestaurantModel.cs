using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantsAPI.Models
{
    public class RestaurantModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Location { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<RestaurantMiscellaneousModel> RestaurantMiscellaneous { get; set; }
        public List<ItemModel> Items { get; set; }


    }
}
