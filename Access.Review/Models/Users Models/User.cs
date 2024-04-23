using Access.Review.Models.Data_Models;
using Access.Review.Models.Enum;
using Microsoft.Identity.Client;

namespace Access.Review.Models.Users_Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }

        public string Email {  get; set; }

        public string Password { get; set; }

        public PhoneNumber PhoneNumber { get; set; }

        public int Trophies { get; set; }

        public double AvgEnjoyment { get; set; }
        public StatusEnum Status {get; set; }

        //public List<Discounts> EarnedDiscounts {get; set; }
        public Photo ProfilePicture { get; set; }
        public ICollection<Photo> Collection { get; set; }
        


        //People Relationships - One
        public Admin? Admin { get; set; }
        public Coordinator? Coordinator { get; set; }
        public User? Friend { get; set; }

        //People Relationships - Many
        public ICollection<Admin>? Admins { get; set; }
        public ICollection<Coordinator>? Coordinators { get; set; }
        public ICollection<User>? Friends { get; set; }

        //Places Relationships - One
        public Event? Event { get; set; }
        public Vendor? Vendor { get; set; }
        public Venue? Venue { get; set; }

        //Places Relationships - Many
        public ICollection<Event>? Events { get; set; }
        public ICollection<Vendor>? Vendors { get; set; }
        public ICollection<Venue>? Venues { get; set; }

    }
}
