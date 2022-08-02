using Microsoft.EntityFrameworkCore;
using MyWebApplicationN.Configration;
using MyWebApplicationN.Models;

namespace MyWebApplicationN.Context
{
    public class AppDbContext : DbContext
    {


        public AppDbContext(DbContextOptions options) : base(options)
        {
            this.Database.EnsureCreated();
        }
        


       public DbSet<Rover> rovers { get; set; }    
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new RoverConfigration());


        }
    }
}
