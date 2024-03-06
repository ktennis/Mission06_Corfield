using CsvHelper.Configuration.Attributes;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_Corfield.Models
{
    public class Joel
    {
        [Key]
        [Required]
        public int MovieId { get; set; }

        [Name("Category")]
        public string? Category { get; set; }

        [Name("Title")]
        [Required(ErrorMessage = "Title is required")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Year is required")]
        [Range(1888, 2024, ErrorMessage = "Year must be between 1888 and 2024")]
        [Name("Year")]
        public int Year { get; set; }

        [Name("Director")]
        public string? Director { get; set; }

        [Name("Rating")]
        public string? Rating { get; set; }

        [Name("Edited")]
        [Required(ErrorMessage = "Edited is required")]

        public string? Edited { get; set; }
        
        [Name("Lent To:")]
        public string? LentTo { get; set; }

        [Required(ErrorMessage = "Copied to Plex is required")]
        public string? Plex { get; set; }
        public string? Notes { get; set; }
        

    }
    
}


