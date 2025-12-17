namespace Sutradhaar.API.Models
{
    public class Vehicle
    {
        public int VehicleId { get; set; }
        public required string VehicleNumber { get; set; }
        public required string VehicleName { get; set; }
        public string? VehicleType { get; set; }   
        public bool IsAC { get; set; }
        public required int SeatingCapacity { get; set; }
        public string? Description { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
