using Access.Review.Models.Users_Models;

namespace Access.Review.Models.Data_Models
{
    public class Vendor
    {
        public Guid Id { get; set; }
        public string VendorName { get; set; }
        public string VendorDescription { get; set;}
        
        public PhoneNumber VendorPhoneNumber { get; set;}

        public ICollection<Photo> VendorPhotos { get; set; }


        //People Relationships - One
        public Coordinator? VendorCoordinator { get; set; }
        public User? VendorUser { get; set; }
        public Admin? VendorAdmin { get; set; }

        //People Relationships - Many
        public ICollection<Coordinator>? VendorCoordinators { get; set;}
        public ICollection<User>? VendorUsers { get; set; }
        public ICollection<Admin>? VendorAdmins { get; set; }

        //Places Relationships - One
        public Venue? VendorVenue { get; set; }
        public Event? VendorEvent { get; set; }
        public Address? VendorAddress { get; set; }

        //Places Relationships - Many
        public ICollection<Venue>? VendorVenues { get; set;}
        public ICollection<Event>? VendorEvents { get; set; }
    }
}