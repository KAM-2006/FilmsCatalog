namespace Controller
{
    using Data;
    using Data.Models;
    public class ActorController
    {
        private FilmsDbContext filmsDbContext;
        public List<Actor> GetAll()
        {
            using (filmsDbContext = new FilmsDbContext())
            {
                return filmsDbContext.Actors.ToList();
            }

        }
        public Actor Get(int id)
        {
            using (filmsDbContext = new FilmsDbContext())
            {
                return filmsDbContext.Actors.Find(id);
            }
        }
        public void Add(Actor actor)
        {
            using (filmsDbContext = new FilmsDbContext())
            {
                filmsDbContext.Actors.Add(actor);
                filmsDbContext.SaveChanges();
            }
        }
        public void Update(Actor actor)
        {
            using (filmsDbContext = new FilmsDbContext())
            {
                var item = filmsDbContext.Actors.Find(actor.Id);
                if (item != null)
                {
                    filmsDbContext.Entry(item).CurrentValues.SetValues(actor);
                    filmsDbContext.SaveChanges();
                }
            }
        }
        public void Delete(int id)
        {
            using (filmsDbContext = new FilmsDbContext())
            {
                var actor = filmsDbContext.Actors.Find(id);
                if (actor != null)
                {
                    filmsDbContext.Actors.Remove(actor);
                    filmsDbContext.SaveChanges();
                }
            }
        }
    }
}