using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace RestaurantsAPI.Models
{
    public class UserModel : IdentityUser
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int  Gender { get; set; }
        public string Dp { get; set; }
        public int  ProfileType { get; set; }
        //public string Country { get; set; }
        //public string City { get; set; }
        //public string Address { get; set; }
        //public DateTime DateOfBirth { get; set; } 
        public DateTime CreatedAt { get; set; }
    }
}
