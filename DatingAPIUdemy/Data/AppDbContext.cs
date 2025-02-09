using DatingAPIUdemy.Entitites;
using Microsoft.EntityFrameworkCore;

namespace DatingAPIUdemy.Data
{
    public class AppDbContext(DbContextOptions options) : DbContext(options)
    {
       /* public AppDbContext(DbContextOptions options) : base(options)
        {
        }
       */

        public DbSet<AppUser> users { get; set; }
    }
}
