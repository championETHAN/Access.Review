using Access.Review.Models.Enum;
using Access.Review.Models.Users_Models;
using System.Numerics;

namespace Access.Review.Models.Data_Models
{
    public class Event
    {
        //General Event Information
        public Guid EventId { get; set; }
        public string EventName { get; set; }
        public string EventsLocationInVenue { get; set; }
        public DateTime EventStartTime { get; set; }
        public DateTime EventEndTime { get; set; }
        public PricingEnum Pricing {get; set; }
        public ICollection<Photo> EventPhotos { get; set; }
        public PhoneNumber CoordinatorsPhoneNumber { get; set; }

        //Event Restrictions
        public int MaxPeopleAttending { get; set; }
        public int CurrentPeopleAttending { get; set; }
        public bool EventTwentyOnePlus { get; set; }

        //Event Amenities 
        public bool EventServesFood { get; set; }
        public bool EventServesAlcohol { get; set; }
        public bool EventRestrooms { get; set; }



        //People Relationships - One
        public User? EventUser { get; set; }
        public Admin? EventAdmin { get; set; }
        public Coordinator? EventCoordinator { get; set; }

        //People Relationships - Many
        public ICollection<User>? EventUsers { get; set; }
        public ICollection<Admin>? EventAdmins { get; set; }
        public ICollection<Coordinator>? EventCoordinators { get; set; }

        //Places Relationships - One
        public Venue? EventVenue { get; set; }
        public Address? EventAddress { get; set; }
        public Vendor? EventVendor { get; set; }

        //Places Relationships - Many
        public ICollection<Vendor>? EventVendors { get; set; }
        public ICollection<Event>? EventsVenues { get; set; }
        
    }
}
