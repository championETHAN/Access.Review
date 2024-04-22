namespace Access.Review.Models.Data_Models
{
    public class Vendor
    {
        public Guid Id { get; set; }
        public string VendorName { get; set; }
        public string VendorDescription { get; set;}
        
        public ICollection<Photo> VendorPhotos { get; set; }


    }
}
