using Microsoft.EntityFrameworkCore;


namespace UsersActivity.API.Data
{
    public class DataContext : DbContext
    {
        //public DataContext() : base() {}
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User> Users => Set<User>();
    }
}
