using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;

namespace nutripuc.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options) { }

        public DbSet<User>? Users { get; set; }


    }
}
