using Microsoft.AspNetCore.Mvc;

namespace WebApplication_Razor.Models
{
    public class Hobby
    {
        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
