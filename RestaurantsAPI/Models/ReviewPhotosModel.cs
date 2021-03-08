using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantsAPI.Models
{
    public class ReviewPhotosModel
    {
        public int Id { get; set; }
        public string Caption { get; set; }
        public string Url { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
