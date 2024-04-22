using Access.Review.Models.Enum;
using Access.Review.Models.Users_Models;

namespace Access.Review.Models.Data_Models
{
    public class Venue
    {
        //General Venue Information
        public Guid EstablishmentsId { get; set; }
        public string EstablishmentsName { get; set; }
        public string EstablishmentsLocation { get; set; }
        public DateTime EstablishmentsHoursOfOperation { get; set; }
        public int EstablishmentsPhoneNumber { get; set; }
        public ICollection<Photo> EstablishmentsPhotos { get; set; }
        public PricingEnum EstablishmentsPricing { get; set; }

        //Venue Restrictions
        public bool EstablishmentTwentyOnePlus { get; set; }
        public int EstablishmentsMaxPeople { get; set; }
        public int EstablishmentsCurrentPeople { get; set; }

        //Venue Amenities
        public bool EstablishmentServesFood { get; set;}
        public bool EstablishmentServesAlcohol { get; set;}


        //public List<EstablishmentsReviews> Reviews
        public ICollection<Coordinator> AllowedCoordinators { get; set; }
        public ICollection<Event> AllowedEvents { get; set; }


    }
}
