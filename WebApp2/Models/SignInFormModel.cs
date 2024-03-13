using System.ComponentModel.DataAnnotations;

namespace AspNetCore.Models;

public class SignInFormModel
{
    [DataType(DataType.EmailAddress)]
    [Display(Name = "Email address", Prompt = "Enter your email address")]
    [Required(ErrorMessage = "Invalid email address")]
    public string Email { get; set; } = null!;

    [DataType(DataType.Password)]
    [Display(Name = "Password", Prompt = "Enter your password")]
    [Required(ErrorMessage = "Invalid password")]
    public string Password { get; set; } = null!;

    [Display(Name = "Remember me")]
    public bool RememberMe { get; set; } = false;
}

