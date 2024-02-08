using System.ComponentModel.DataAnnotations;

namespace MovieTickets.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

    //    [Required(ErrorMessage = "Profile Image is required")]
        [Display(Name = "Profile Image")]
        public required string ProfileImgUrl { get; set; }

        [Display(Name = "Full Name")]
   //     [Required(ErrorMessage = "Full Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Full Name must be between 3 and 50 chars")]
        public required string FullName { get; set; }
        [Display(Name = "Bio")]
  //      [Required(ErrorMessage = "Biography is required")]

        public required string Bio { get; set; }

        //Relationships
        public List<Actor_Movie>? Actor_Movies { get; set; }

    }
}
