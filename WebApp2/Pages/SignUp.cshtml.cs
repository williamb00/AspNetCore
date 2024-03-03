using AspNetCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetCore.Pages
{
    public class SignUpModel : PageModel
    {

        public SignUpFormModel Form { get; set; } = new SignUpFormModel();
        public void OnGet()
        {
        }
    }
}
