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
        public List<string> SortByrating(List<Film> films)
        {
            List<string> result = new List<string>(); 
            List<Film> sortedfilms = new List<Film>();
            sortedfilms = films.OrderByDescending(x => x.Rating).ToList();
            for (int i = 0; i < 3; i++)
            {
                result.Add(sortedfilms[i].Title + " " + sortedfilms[i].Rating);
            }
            return result;
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
        public List <string> SearchInfFilmByActor(List<Film> films, string firstname, string lastname)
        {
            List<string> result = new List<string>();
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
                            result.Add(f.Title);
                        }
                    }
                }
            }
            return result;
        }
        public List <string> SearchInfByGenre(List<Film> films, string genreName)
        {
            List<string> result = new List<string>();
            foreach (var film in films)
            {
                if (film.Genre.Name == genreName)
                {
                   result.Add(film.Title);
                }
            }
            return result;
        }
        public int GetByName(string title)
        {
            List<Film> films = this.GetAll();
            int id = 0;
            foreach (Film film in films)
            {
                if (film.Title == title)
                {
                    id = film.Id;
                }
            }
            return id;
        }
    }
}
