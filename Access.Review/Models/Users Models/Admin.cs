using Access.Review.Models.Data_Models;
using Access.Review.Models.Enum;
using Microsoft.Identity.Client;

namespace Access.Review.Models.Users_Models
{
    public class Admin
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public StatusEnum Status { get; set; }
        public int Trophies { get; set; }
        //public List<Discounts> EarnedDiscounts {get; set; }
        public Photo ProfilePicture { get; set; }
        public ICollection<Photo> Collection { get; set; }



        //People Relationships - One
        public User? User { get; set; }
        public Coordinator? Coordinator { get; set; }

        //People Relationships - Many
        public ICollection<User>? Users { get; set; }
        public ICollection<Coordinator>? Coordinators { get; set; }

        //Places Relationships - One
        public Vendor? Vendor { get; set; }
        public Event? Event { get; set; }
        public Venue? Venue { get; set; }

        //Places Relationships - Many
        public ICollection<Venue>? Venues { get; set; }
        public ICollection<Vendor>? Vendors { get; set; }
        public ICollection<Event>? Events { get; set; }
    }
}
