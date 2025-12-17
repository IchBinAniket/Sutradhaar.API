using Microsoft.EntityFrameworkCore;
using Sutradhaar.API.Models;

namespace Sutradhaar.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Enquiry> Enquiries { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<TicketBooking> TicketBookings { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }

    }
}
