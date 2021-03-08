using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantsAPI.Models
{
    public class ReviewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double EnvRating { get; set; }
        public double CleanlinessRating { get; set; }
        public double ServiceRating { get; set; }
        public List<FoodReview> FoodReviews { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<TagModel> ReviewTags { get; set; }
        public RestaurantModel Restaurant { get; set; }
        public UserModel User { get; set; }
        public List<ReviewPhotosModel> ReviewPhotos { get; set; }
        public List<Reaction> Reactions { get; set; }
        public List<ReviewComment> ReviewComents { get; set; }

    }
}
