using Access.Review.Models.Users_Models;

namespace Access.Review.Models.Data_Models
{
    public class PhoneNumber
    {
        public int AreaCode { get; set; }
        public int Exchange { get; set; } 
        public int Siffix { get; set; }
        public int? Extension { get; set; }


        //People Relationships - One
        public User? User { get; set; } //a phone number can only have one user
        public Coordinator? Coordinator { get; set; } //a phone number can only have one establishment 

        //People Relationships - Many
        //Places Relationships - One
        public Venue? Venue { get; set; } //a phone number can only have one establishment 
        public Vendor? Vendor { get; set; } //a phone number can only have one vendor
   
        //Places Relationships - Many

    }
}
