using Microsoft.EntityFrameworkCore;

namespace FirstCoreApp
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Employee>Employees { set; get; }
    }
}