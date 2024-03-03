using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AspNetCore.Models
{
    public class SignUpFormModel
    {
        [DisplayName("First name")]
        [Required(ErrorMessage = "Invalid first name")]
        public string FirstName { get; set; } = null!;

        [DisplayName("Last name")]
        [Required(ErrorMessage = "Invalid last name")]
        public string LastName { get; set; } = null!;

        [DisplayName("Email address")]
        [Required(ErrorMessage = "Invalid email address")]
        public string Email { get; set; } = null!;

        [DisplayName("Password")]
        [Required(ErrorMessage = "Invalid password")]
        public string Password { get; set; } = null!;

        [DisplayName("Confirm Password")]
        [Required(ErrorMessage = "Must confirm password")]
        [Compare(nameof(Password), ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; } = null!;

        [DisplayName("Terms & Conditions")]
        [Required(ErrorMessage = "You must agree to the terms & conditions")]
        public bool Terms { get; set; }
    }
}
