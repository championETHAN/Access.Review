﻿using Access.Review.Models.Data_Models;
using Access.Review.Models.Enum;

namespace Access.Review.Models.Users_Models
{
    public class Admin
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public StatusEnum Status { get; set; }
        public int Trophies { get; set; }
        //public List<Discounts> EarnedDiscounts {get; set; }
        public Photo ProfilePicture { get; set; }
        public ICollection<Photo> Collection { get; set; }
    }
}
