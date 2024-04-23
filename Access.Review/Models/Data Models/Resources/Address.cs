namespace Access.Review.Models.Data_Models
{
    public class Address
    {
        public int AddressNumber {  get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }

        //Places Relationships - One
        public Venue? Venue { get; set; } //An Address can have one venue(places where events can be)
        public Vendor? Vendor { get; set; } //An Address can have one Vendor
        public Event? Event { get; set; } //An Address can have one Event

        //Places Relationships - Many
        public ICollection<Event>? Events { get; set; } //A single Address can have many events
        public ICollection<Vendor>? Vendors { get; set; }  // A singel Address Can have many Vendors
        public ICollection<Venue>? Venues { get; set; } // A single Address can have many Venues(places where events can be)
    }
}
