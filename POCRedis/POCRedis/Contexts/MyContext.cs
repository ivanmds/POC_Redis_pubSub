using Microsoft.EntityFrameworkCore;
using POCRedis.Domain.Entities;

namespace POCRedis.Contexts
{
    public class MyContext : DbContext
    {
        public MyContext() { }

        public DbSet<Person> Persons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("POCRedis");
        }
    }
}
