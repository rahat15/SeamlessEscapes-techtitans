using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace SeamlessEscapes.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

        // DbSet for each entity, representing a table in the database
        public DbSet<User> Users { get; set; }
        public DbSet<PlanTrip> PlanTrips { get; set; }
        public DbSet<Itinerary> Itineraries { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<Transport> Transports { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Road> Roads { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Include any specific model configuration here
            modelBuilder.Entity<Transport>()
                .HasDiscriminator<string>("TransportType")
                .HasValue<Flight>("Flight")
                .HasValue<Road>("Road");
        }
    }
}
