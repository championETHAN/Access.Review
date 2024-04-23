using Access.Review.Models.Data_Models;
using Access.Review.Models.Users_Models;
using Microsoft.EntityFrameworkCore;

namespace Access.Review.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { 

        }

        // Things and places
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Venue> Venues { get; set; }

        // People
        public DbSet<Admin> Admins { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Coordinator> Coordinators { get; set; }

        //Resources
        public DbSet<PhoneNumber> PhoneNumbers { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Address> Addresses { get; set; }

    }
}
