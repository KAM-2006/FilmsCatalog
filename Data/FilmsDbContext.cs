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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conStr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=FilmsDb;Integrated Security=True";
            optionsBuilder.UseSqlServer(conStr);
        }

        public DbSet<Film> Films { get; set; }
    }
}
