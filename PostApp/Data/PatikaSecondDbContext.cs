using Microsoft.EntityFrameworkCore;
using PostApp.Data.Entities;

namespace PostApp.Data
{
    public class PatikaSecondDbContext : DbContext
    {
        public PatikaSecondDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(user =>
            {
                user.ToTable("Users");
                user.HasKey(u => u.Id);

                user.HasMany(u => u.Posts).WithOne(p => p.User).HasForeignKey(p => p.UserId);
            });

            modelBuilder.Entity<Post>(post =>
            {
                post.ToTable("Posts");
                post.HasKey(p => p.Id);
            });
        }
    }
}
