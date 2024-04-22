namespace Access.Review.Models.Data_Models
{
    public class Photo
    {
        public Guid ID { get; set; }

        public string? Title { get; set; }

        public string? Description { get; set; }

        public string? Author { get; set; }

        public byte[] Bytes { get; set; }

    }
}
