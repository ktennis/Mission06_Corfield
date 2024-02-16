using Microsoft.EntityFrameworkCore;

namespace Mission06_Corfield.Models
{
    public class MoviesContext : DbContext
    {
            public MoviesContext(DbContextOptions<MoviesContext> options) : base(options)
            {

            }
            public DbSet<JoelContext> Movies { get; set; }

        
    }
}

