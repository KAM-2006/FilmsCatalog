namespace Controller
{
    using Data;
    using Data.Models;
    using Microsoft.EntityFrameworkCore;
    using System.Text;

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
        private ActorController actorController = new ActorController();
        public string SortByrating(List<Film> films)
        {
            StringBuilder sb = new StringBuilder();
            List<Film> sortedfilms = new List<Film>();
            sortedfilms = films.OrderByDescending(x => x.Rating).ToList();
            for (int i = 0; i < 3; i++)
            {
                sb.AppendLine(sortedfilms[i].Title + " " + sortedfilms[i].Rating);
            }
            return sb.ToString().TrimEnd();
        }
        //информация да излиза за един филм по зададено заглавие
        public string SearchInfFilm(List<Film> films, string title)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in films)
            {
                if (item.Title == title)
                {
                    sb.Append("Film: ");
                    sb.AppendLine(item.ToString());
                    sb.AppendLine($"Actors in {item.Title}:");
                    List<FilmActor> filmActors = item.FilmsActors.Where(x => x.FilmId == item.Id).ToList();
                    List<Actor> actors = actorController.GetAll();
                    foreach (var actor in actors)
                    {
                        foreach (var filmActor in filmActors)
                        {
                            if (actor.Id == filmActor.ActorId)
                            {
                                sb.AppendLine(actor.ToString());
                            }
                        }
                    }
                }
            }
            return sb.ToString().TrimEnd();
        }
        //търсене на филмите по зададен актьор
        public string SearchInfFilmByActor(List<Film> films, string firstname, string lastname)
        {
            StringBuilder sb = new StringBuilder();
            int id = actorController.GetByName(firstname, lastname);
            foreach (var film in films)
            {
                List<FilmActor> filmActors = film.FilmsActors.Where(x => x.ActorId == id).ToList();
                List<Film> filmsAll = this.GetAll();
                foreach (var f in filmsAll)
                {
                    foreach (var filmActor in filmActors)
                    {
                        if (f.Id == filmActor.FilmId)
                        {
                            sb.AppendLine(f.Title);
                        }
                    }
                }
            }
            return sb.ToString().TrimEnd();
        }
        public string SearchInfByGenre(List<Film> films, string genreName)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var film in films)
            {
                if (film.Genre.Name == genreName)
                {
                    sb.AppendLine(film.Title);
                }
            }
            return sb.ToString().TrimEnd();
        }
    }
}
