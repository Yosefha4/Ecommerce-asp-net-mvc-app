using System.ComponentModel.DataAnnotations;

namespace MovieTickets.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        public string ProfileImgUrl { get; set; }
        public string FullName { get; set; }

        public string Bio { get; set; }
    }
}
