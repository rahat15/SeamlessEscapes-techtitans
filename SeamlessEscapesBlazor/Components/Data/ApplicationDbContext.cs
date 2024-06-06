/*
using Microsoft.EntityFrameworkCore;
using SeamlessEscapesBlazor.Models;

namespace SeamlessEscapesBlazor.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<Interest> Interests { get; set; }
        public DbSet<PlanTrip> PlanTrips { get; set; }
        public DbSet<Road> Roads { get; set; }
        public DbSet<Transport> Transports { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
*/

using Microsoft.EntityFrameworkCore;
using SeamlessEscapesBlazor.Models;

namespace SeamlessEscapesBlazor.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Email).IsRequired();
                entity.Property(e => e.Username).IsRequired();
                entity.Property(e => e.Password).IsRequired();
            });
        }
    }
}



