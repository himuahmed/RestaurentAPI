using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantsAPI.Models
{
    public class ReviewComment
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedAt { get; set; }
        public Reaction CommentReactions { get; set; }

    }
}
