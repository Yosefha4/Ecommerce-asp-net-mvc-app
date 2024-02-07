using MovieTickets.Data.Enum;
using System.ComponentModel.DataAnnotations;

namespace MovieTickets.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public double Price { get; set; }

        public string ImageUrl { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public MovieCategory MovieCategory { get; set; }



        public int MyProperty { get; set; }
    }
}
