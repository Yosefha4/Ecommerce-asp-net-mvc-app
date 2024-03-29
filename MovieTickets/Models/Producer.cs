﻿using System.ComponentModel.DataAnnotations;

namespace MovieTickets.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Profile Image")]
        public string ProfileImgUrl { get; set; }
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        [Display(Name = "Bio")]
        public string Bio { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; } 
    }
}
