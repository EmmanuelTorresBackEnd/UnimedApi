using Microsoft.EntityFrameworkCore;
using UnimedWebApi.Models;

namespace UnimedWebApi.Contexts
{
    public class UnimedContext : DbContext
    {
        public UnimedContext()
        {
        }
        public UnimedContext(DbContextOptions<UnimedContext> options) : base(options)
        {
        }
        protected override void
        OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Data Source = WIN-4FKM2ALTJ4D\\SQLEXPRESS; initial catalog = UnimedWebApiDb; Integrated Security = true");
            }
        }
        public DbSet<Cliente> Cliente { get; set; }
    }

}
