namespace Sutradhaar.API.Models
{
    public class Package
    {
        public int PackageId { get; set; }
        public required string Title { get; set; }
        public required string Destination { get; set; }   
        public string? PriceText { get; set; }
        public string? Description { get; set; }
        public bool TravelByBus { get; set; } = true;
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
