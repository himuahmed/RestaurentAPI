using System;
using System.ComponentModel.DataAnnotations;

namespace RestaurantsAPI.Models
{
    public class UserRegistration
    {
        [Required(ErrorMessage = "Enter your name.")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Name must be between 3 to 30 characters.")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter your email.")]
        [EmailAddress(ErrorMessage = "Enter a valid email.")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter your email.")]
        [Display(Name = "Phone")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please choose your gender.")]
        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Please select your birthdate.")]
        [Display(Name = "Birth date")]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Please select your city.")]
        [Display(Name = "City")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please select your country.")]
        [Display(Name = "Country")]
        public string Country { get; set; }

        [Display(Name = "Address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter a password.")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Password must be between 6 to 20 characters.")]
        [Compare("ConfirmPassword", ErrorMessage = "Password didn't match.")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please confirm your password.")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }

        public DateTime CreatedAt { get; set; }

        public UserRegistration()
        {
            CreatedAt = DateTime.Now;
        }
    }
}
