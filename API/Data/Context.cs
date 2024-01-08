using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Data 
{
    public class Context : DbContext 
    {
        public Context(DbContextOptions<Context> o) : base(o)
        {
            
        }

        public DbSet<Animal> Animals { get; set; }
    }
}