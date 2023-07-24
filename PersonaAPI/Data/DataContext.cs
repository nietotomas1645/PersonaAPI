global using Microsoft.EntityFrameworkCore;

namespace PersonaAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
        }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Person> Persons {get; set; }
    }
}
