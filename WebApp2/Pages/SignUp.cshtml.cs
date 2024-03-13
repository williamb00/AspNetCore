using AspNetCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetCore.Pages;

public class SignUpModel : PageModel
{ 
        public string PageTitle { get; set; } = "Sign Up";
        
        [BindProperty]
        public SignUpFormModel Form { get; set; } = new SignUpFormModel();


        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            return RedirectToPage("/index");
        }
}