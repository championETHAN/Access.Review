using Access.Review.Models.Data_Models;

namespace Access.Review.Models.Users_Models
{
    public class Coordinator
    {
       //public is tag that is applied to Users and Admins
       public ICollection<Venue> Venues { get; set; } //places they can make events for
       public ICollection<Event> Events { get; set; }  //Events they have made
       public ICollection<User> Followers { get; set; } //Users who attend their events or like their events
       public ICollection<Vendor> Vendors { get; set; } //List Of Vendors who have worked with The Coordinator before
    }
}
