using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WiproDemoRazorApp.Models;

namespace WiproDemoRazorApp.Pages
{
    public class EmployeeModel : PageModel
    {
        [BindProperty]
        public Employee emps { get; set; } = new Employee();
        public void OnGet()
        {
            //This method will be called when the page is loaded
        }

        public IActionResult OnPost() 
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            return Page();
        }
    }
    
}