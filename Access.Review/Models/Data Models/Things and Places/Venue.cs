using Access.Review.Models.Enum;
using Access.Review.Models.Users_Models;

namespace Access.Review.Models.Data_Models
{
    public class Venue
    {
        //General Venue Information
        public Guid EstablishmentsId { get; set; }
        public string EstablishmentsName { get; set; }
        public Address EstablishmentsLocation { get; set; }
        public DateTime EstablishmentsHoursOfOperation { get; set; }
        public PhoneNumber EstablishmentsPhoneNumber { get; set; }
        public ICollection<Photo> EstablishmentsPhotos { get; set; }
        public PricingEnum EstablishmentsPricing { get; set; }

        //Venue Restrictions
        public bool EstablishmentTwentyOnePlus { get; set; }
        public int EstablishmentsMaxPeople { get; set; }
        public int EstablishmentsCurrentPeople { get; set; }

        //Venue Amenities
        public bool EstablishmentServesFood { get; set;}
        public bool EstablishmentServesAlcohol { get; set;}




        //People Relationships - One
        public User? VenueUser { get; set; }
        public Coordinator? VenueCoordinator { get; set; }
        public Admin? VenueAdmin { get; set; }

        //People Relationships - Many
        public ICollection<Coordinator>? VenueCoordinators { get; set; }
        public ICollection<User>? VenueUsers { get; set; }
        public ICollection<Admin>? VenueAdmins { get; set; }

        //Places Relationships - One
        public Vendor? VenueVendor { get; set; }
        public Event? VenueEvent { get; set; }
        public Address? VenueAddress { get; set; }


        //Places Relationships - Many
        public ICollection<Vendor>? VenueVendors { get; set; }
        public ICollection<Event>? VenueEvents { get; set; }
    }
}