using Access.Review.Models.Users_Models;

namespace Access.Review.Models.Data_Models
{
    public class Photo
    {
        public Guid ID { get; set; }

        public string? Title { get; set; }

        public string? Description { get; set; }

        public string? Author { get; set; }

        public byte[] Bytes { get; set; }


        //People Relationships - One
        public User? User { get; set; } //A photo can have one user
        public Admin? Admin { get; set; } //A photo can have one admin
        public Coordinator? Coordinator { get; set; } //A photo can have one Coordinator

        //People Relationships - Many
        public ICollection<Coordinator>? Coordinators { get; set; } //A photo can have many Coordinators
        public ICollection<User>? Users { get; set; } //A photo can have many Users
        public ICollection<Admin>? Admins { get; set; } //A photo can have many Admins


        //Places Relationships - One
        public Vendor? Vendor { get; set; } //A photo can have one vendor 
        public Venue? Venue { get; set; } //A photo can have one Venue 
        public Address? Address { get; set; } //A photo can have one Adress 
        public Event? Event { get; set; } //A photo can have one Event 

        //Places Relationships - Many
        public ICollection<Vendor>? Vendors { get; set; } //A photo can have Many Vendors


    }
}
