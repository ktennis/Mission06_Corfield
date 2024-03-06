using Microsoft.EntityFrameworkCore;

namespace Mission06_Corfield.Models
{
    // The MoviesContext class inherits from DbContext, which is provided by Entity Framework Core
    public class MoviesContext : DbContext
    {
        // Constructor that accepts DbContextOptions as a parameter
        public MoviesContext(DbContextOptions<MoviesContext> options) : base(options)
        {
            // Passes the options to the base DbContext class constructor
        }

        // DbSet property to represent the movies table in the database
        public DbSet<Joel> Movies { get; set; }
    }
}
