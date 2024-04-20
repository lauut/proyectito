using Microsoft.EntityFrameworkCore;
namespace proyectito.Models
{
    public class proyectitoContext : DbContext
    {
        public proyectitoContext(DbContextOptions options) : base (options) {


        }
        public DbSet<usuario> usuario { get; set; }
        public DbSet<roles> roles { get; set; }

    }
}
