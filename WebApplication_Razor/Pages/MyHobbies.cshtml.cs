using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication_Razor.Models;

namespace WebApplication_Razor.Pages
{
    public class MyHobbiesModel : PageModel
    {
        public List<Hobby> HobbyList { get; set; } = new List<Hobby>();
        public async Task OnGet()
        {
            HobbyList.Add(new Hobby()
            {
                Id = 1, Name = "Hobby 1", Description = "Hobby Description 1"
            });
            HobbyList.Add(new Hobby()
            {
                Id = 2, Name = "Hobby 2", Description = "Hobby Description 2"
            });
            HobbyList.Add(new Hobby()
            {
                Id = 3, Name = "Hobby 3", Description = "Hobby Description 3"
            });
        }
    }
}
