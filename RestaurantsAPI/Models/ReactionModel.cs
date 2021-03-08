using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantsAPI.Models
{
    public class Reaction
    {
        public int Id { get; set; }
        public bool IsLiked { get; set; }
        public bool IsHelpful { get; set; }
        public UserModel User { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
