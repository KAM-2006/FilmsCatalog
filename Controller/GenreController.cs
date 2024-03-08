using Data;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class GenreController
    {
        private FilmsDbContext filmsDbContext { get; set; }
        public List<Genre> GetAll()
        {
            using (filmsDbContext = new FilmsDbContext())
            {
                return filmsDbContext.Genres.ToList();
            }

        }
        public Genre Get(int id)
        {
            using (filmsDbContext = new FilmsDbContext())
            {
                return filmsDbContext.Genres.Find(id);
            }
        }
        public void Add(Genre genre)
        {
            using (filmsDbContext = new FilmsDbContext())
            {
                filmsDbContext.Genres.Add(genre);
                filmsDbContext.SaveChanges();
            }
        }
        public void Update(Genre genre)
        {
            using (filmsDbContext = new FilmsDbContext())
            {
                var item = filmsDbContext.Genres.Find(genre.Id);
                if (item != null)
                {
                    filmsDbContext.Entry(item).CurrentValues.SetValues(genre);
                    filmsDbContext.SaveChanges();
                }
            }
        }
        public void Delete(int id)
        {
            using (filmsDbContext = new FilmsDbContext())
            {
                var genre = filmsDbContext.Genres.Find(id);
                if (genre != null)
                {
                    filmsDbContext.Genres.Remove(genre);
                    filmsDbContext.SaveChanges();
                }
            }
        }
    }
}
