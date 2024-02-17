using System.ComponentModel.DataAnnotations;

namespace Movie_Collection.Models
{
    public class Film
    {
        [Key]
        [Required]
        public int FilmID { get; set; }
        [Required]
        public string FilmCategory { get; set; }
        [Required]
        public string FilmTitle { get; set; }
        [Required]
        public int FilmYear { get; set; }
        [Required]
        public string FilmDirector { get; set; }
        [Required]
        public string FilmRating { get; set; }
        public bool? FilmEdited { get; set; }
        public string? FilmLentTo { get; set; }
        [StringLength(25)]
        public string? FilmNotes { get; set; }
    }
}
