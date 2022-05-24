using Microsoft.EntityFrameworkCore;
using my_api.Models;

namespace my_api
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Job> Jobs { get; set; }

        public DbSet<Exchanges> Exchanges { get; set; }

        //public DbSet<Surcharge> Surcharges { get; set; }

        public DbSet<Values> Values { get; set;}

    }
}
