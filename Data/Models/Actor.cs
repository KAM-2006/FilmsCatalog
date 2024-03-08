namespace Data.Models
{
    using System.ComponentModel.DataAnnotations;
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public int Years { get; set; }
        public string DateOfBirth { get; set; }
        public ICollection<FilmActor> FilmsActors { get; set; }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} {this.Years} {this.DateOfBirth}";
        }
    }
}