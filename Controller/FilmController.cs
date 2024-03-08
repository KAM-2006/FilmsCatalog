namespace Controller
{
    using Data;
    using Data.Models;
    public class FilmController
    {
        private FilmsDbContext filmsDbContext;

        public List<Film> GetAll()
        {
            using (filmsDbContext = new FilmsDbContext())
            {
                return filmsDbContext.Films.ToList();
            }
        }

        public Film Get(int id)
        {
            using (filmsDbContext = new FilmsDbContext())
            {
                return filmsDbContext.Films.Find(id);
            }
        }

        public void Add(Film project)
        {
            using (filmsDbContext = new FilmsDbContext())
            {
                filmsDbContext.Films.Add(project);
                filmsDbContext.SaveChanges();
            }
        }

        public void Update(Film project)
        {
            using (filmsDbContext = new FilmsDbContext())
            {
                var item = filmsDbContext.Films.Find(project.Id);
                if (item != null)
                {
                    filmsDbContext.Entry(item).CurrentValues.SetValues(project);
                    filmsDbContext.SaveChanges();
                }
            }
        }

        public void Delete(int id)
        {
            using (filmsDbContext = new FilmsDbContext())
            {
                var project = filmsDbContext.Films.Find(id);
                if (project != null)
                {
                    filmsDbContext.Films.Remove(project);
                    filmsDbContext.SaveChanges();
                }
            }
        }
    }
}
