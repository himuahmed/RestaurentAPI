using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace RestaurantsAPI.Models
{
    public class UserModel : IdentityUser
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; } 
        public DateTime CreatedAt { get; set; }
    }
}
