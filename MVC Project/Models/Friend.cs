using System.ComponentModel.DataAnnotations;

namespace MVC_Project.Models
{
    public class Friend
    {
        [Required(ErrorMessage = "FriendID is required")]
        public int FriendID { get; set; }

        [Required(ErrorMessage = "Friend Name is required")]
        [Display(Name = "Friend Name")]
        [StringLength(25, ErrorMessage = "Friend Name should not exceed 25 characters")]
        public string FriendName { get; set; }

        [StringLength(25, ErrorMessage = "Place should not exceed 25 characters")]
        public string Place { get; set; }
    }
}
