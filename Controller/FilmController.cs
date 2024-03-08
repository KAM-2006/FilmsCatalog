namespace Controller
{
    using Data;
    using Data.Models;
    using Microsoft.EntityFrameworkCore;

    public class FilmController
    {
        private FilmsDbContext filmsDbContext;

        public List<Film> GetAll()
        {
            using (filmsDbContext = new FilmsDbContext())
            {
                filmsDbContext.Films
                    .Include(f => f.FilmsActors)
                    .ThenInclude(a => a.Actor)
                    .ToList();
                return filmsDbContext.Films.Include(g => g.Genre).ToList();
            }
        }

        public Film Get(int id)
        {
            using (filmsDbContext = new FilmsDbContext())
            {
                return filmsDbContext.Films.Find(id);
            }
        }

        public void Add(Film film)
        {
            using (filmsDbContext = new FilmsDbContext())
            {
                filmsDbContext.Films.Add(film);
                filmsDbContext.SaveChanges();
            }
        }

        public void Update(Film film)
        {
            using (filmsDbContext = new FilmsDbContext())
            {
                var item = filmsDbContext.Films.Find(film.Id);
                if (item != null)
                {
                    filmsDbContext.Entry(item).CurrentValues.SetValues(film);
                    filmsDbContext.SaveChanges();
                }
            }
        }

        public void Delete(int id)
        {
            using (filmsDbContext = new FilmsDbContext())
            {
                var film = filmsDbContext.Films.Find(id);
                if (film != null)
                {
                    filmsDbContext.Films.Remove(film);
                    filmsDbContext.SaveChanges();
                }
            }
        }
    }
}
