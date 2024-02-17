using Microsoft.EntityFrameworkCore;

namespace Movie_Collection.Models
{
    public class EnterMoviesContext : DbContext
    {
        public EnterMoviesContext(DbContextOptions<EnterMoviesContext> options) : base (options)
        {
        }

        public DbSet<Film> Films { get; set; }
    }
}
