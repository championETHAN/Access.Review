using Access.Review.Models.Enum;

namespace Access.Review.Models.Users_Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }

        public string Email {  get; set; }

        public string Password { get; set; }

        public int Trophies { get; set; }

        public double AvgEnjoyment { get; set; }
        public StatusEnum Status {get; set; }

        //public List<Discounts> EarnedDiscounts {get; set; }
        //public img ProfilePicture {get; set;} 
        //public List<EventPhotos> Collection {get; set;}
    }
}
