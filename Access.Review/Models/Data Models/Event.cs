using Access.Review.Models.Enum;

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
        //public List<PastEventPhotos> EventPhotos {get; set;}
        public string CoordinatorsPhoneNumber { get; set; }

        //Event Restrictions
        public int MaxPeopleAttending { get; set; }
        public int CurrentPeopleAttending { get; set; }
        public bool EventTwentyOnePlus { get; set; }

        //Event Amenities 
        public bool EventServesFood { get; set; }
        public bool EventServesAlcohol { get; set; }
        public bool EventRestrooms { get; set; }

        public ICollection<Users_Models.Coordinator> EventCoordinator {get; set;}
        public VenueProfile EventVenue { get; set; }

    }
}
