namespace Data.Models
{
    using System.ComponentModel.DataAnnotations;
    public class Film
    {
        public Film()
        {

        }
        public Film(string title, string filmDirector, string dateOfReleasing, 
            double rating, int genreId)
        {
            this.Title = title;
            this.FilmDirector = filmDirector;
            this.DateOfReleasing = dateOfReleasing; 
            this.Rating = rating;
            this.GenreID = genreId;
        }
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string FilmDirector { get; set; }
        public string DateOfReleasing { get; set; }
        public double Rating { get; set; }
        public int GenreID { get; set; }    
        public Genre Genre { get; set; }
        public ICollection<FilmActor> FilmsActors { get; set; }

        public override string ToString()
        {
            return $"{this.Title} - {this.FilmDirector}, {this.DateOfReleasing}, {this.Rating}/10 {this.GenreID}.";
        }
    }
}
