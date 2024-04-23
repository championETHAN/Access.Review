using Access.Review.Models.Data_Models;
using Access.Review.Models.Enum;

namespace Access.Review.Models.Users_Models
{
    public class Coordinator
    {
        public Guid Id { get; set; }
        public string CoordinatorsName { get; set; }

        public string CoordinatorsEmail { get; set; }

        public string CoordinatorsPassword { get; set; }

        public PhoneNumber CoordinatorsPhoneNumber { get; set; }

        public int CoordinatorsTrophies { get; set; }

        public double CoordinatorsAvgEnjoyment { get; set; }
        public StatusEnum Status { get; set; }


        //public List<Discounts> EarnedDiscounts {get; set; }
        public Photo ProfilePicture { get; set; }
        public ICollection<Photo> Collection { get; set; }

       public Vendor? CoordinatorsVendor { get; set; }
       public Venue? CoordinatorsVenue { get; set; }
       public User? CoordinatorsFollower {  get; set; } 
       public Event? CoordinatorEvent { get; set; }

       public ICollection<Venue>? CoordinatorsVenues { get; set; } //places they can make events for
       public ICollection<Event>? CoordinatorsEvents { get; set; }  //Events they have made
       public ICollection<User>? CoordinatorsFollowers { get; set; } //Users who attend their events or like their events
       public ICollection<Vendor>? CoordinatorsVendors { get; set; } //List Of Vendors who have worked with The Coordinator before
    }
}
