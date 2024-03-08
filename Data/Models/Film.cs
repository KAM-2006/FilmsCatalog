namespace Data.Models
{
    using System.ComponentModel.DataAnnotations;
    public class Film
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string FilmDirector { get; set; }
        public string DateOfCreating { get; set; }
        public double Rating { get; set; }
    }
}
