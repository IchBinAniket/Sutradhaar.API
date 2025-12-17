namespace Sutradhaar.API.Models
{
    public class Enquiry
    {
        public int EnquiryId { get; set; }
        public required string Name { get; set; }
        public required string Phone { get; set; }
        public string? Destination { get; set; }
        public string? Message { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
