using AspNetCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetCore.Pages
{
    public class SignUpModel : PageModel
    {
        public string PageTitle { get; set; } = "Sign Up";
        public SignUpFormModel Form { get; set; } = null!;


        public void OnGet()
        {
        }

        public void OnPost()
        {
        }
    }
}
