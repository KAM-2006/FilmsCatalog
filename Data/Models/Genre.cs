using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Genre
    {
        public Genre()
        {

        }
        public Genre(string name)
        {
            this.Name = name;   
        }
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<Film> Films { get; set; }
    }
}
