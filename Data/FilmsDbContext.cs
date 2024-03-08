namespace Data
{
    using Data.Models;
    using Microsoft.EntityFrameworkCore;
    public class FilmsDbContext : DbContext
    {
        public FilmsDbContext()
        {
            Database.EnsureCreated();
        }

        public DbSet<Film> Films { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<FilmActor> FilmsActors { get; set; }
        public DbSet<Genre> Genres { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conStr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=FilmsDb;Integrated Security=True";
            optionsBuilder.UseSqlServer(conStr);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //да няма повтарящи се редове в свързващата таблица
            modelBuilder.Entity<FilmActor>().HasKey(fa => new
            { fa.FilmId, fa.ActorId });
        }

    }
}
