using Microsoft.EntityFrameworkCore;
using RunGroupApp.Models;

namespace RunGroupApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Races>  Races{get; set;}
        public DbSet<club> Clubs{get; set;}
        public DbSet<Address> Addresses { get; set;}
    }
}
