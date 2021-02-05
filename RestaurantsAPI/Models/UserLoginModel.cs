using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantsAPI.Models
{
    public class UserLoginModel
    {
        [Required(ErrorMessage = "Please enter your username.")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Please enter your password.")]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
