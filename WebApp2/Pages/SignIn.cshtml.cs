using AspNetCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetCore.Pages;
public class signinModel : PageModel
{
    public string PageTitle { get; set; } = "Sign In";

    [BindProperty]
    public SignInFormModel Form { get; set; } = new SignInFormModel();
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

