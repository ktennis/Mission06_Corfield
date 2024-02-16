using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Mission06_Corfield.Models
{
    public class JoelContext
    {
        [Key]
        [Required(ErrorMessage = "Category is required")]
        public int MovieID { get; set; }
        
        [Required(ErrorMessage = "Category is required")]
        public required string Category { get; set; }

        [Required(ErrorMessage = "Category is required")]
        public required string Title { get; set; }

        [Required(ErrorMessage = "Category is required")]
        public required int Year { get; set; }
        
        [Required(ErrorMessage = "Category is required")]
        public required string Director { get; set; }
        public string? Rating { get; set; }
        public bool? Edited { get; set; }
        public string? LentTo { get; set; }
        public string? Notes { get; set; }
        

    }
    
}


