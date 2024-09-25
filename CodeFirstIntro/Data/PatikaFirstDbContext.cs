using CodeFirstIntro.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstIntro.Data
{
    public class PatikaFirstDbContext : DbContext
    {
        public PatikaFirstDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Game> Games { get; set; }
        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Game>(game =>
            {
                game.ToTable("Games");
                game.HasKey(g => g.Id);

                game.Property(g => g.Rating).HasColumnType("decimal(2,1)");
            });

            modelBuilder.Entity<Movie>(movie =>
            {
                movie.ToTable("Movies");
                movie.HasKey(movie => movie.Id);
            });
        }
    }
}
