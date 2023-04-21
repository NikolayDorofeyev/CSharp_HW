using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication_Razor.Models;

namespace WebApplication_Razor.Pages
{
    public class HobbyModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }

        [BindProperty(SupportsGet = true)]
        public string Name { get; set; }

        public Hobby Hobby { get; set; }

        public async Task OnGetAsync() => Hobby = new Hobby()
        {
            Id = 1, Name = "Hobby 1", Description = "Hobby Description 1"
        };
    }
}
