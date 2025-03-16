using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Title { get; set; }
    }
}
