using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantsAPI.Models
{
    public class DiscussionModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<Reaction> Reactions { get; set; }
        public List<ReviewComment> DiscussionComments { get; set; }
        public UserModel User { get; set; }
    }
}
