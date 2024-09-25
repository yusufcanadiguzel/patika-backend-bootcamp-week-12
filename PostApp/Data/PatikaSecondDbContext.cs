using Microsoft.EntityFrameworkCore;

namespace PostApp.Data
{
    public class PatikaSecondDbContext : DbContext
    {
        public PatikaSecondDbContext(DbContextOptions options) : base(options)
        {
            
        }
    }
}
