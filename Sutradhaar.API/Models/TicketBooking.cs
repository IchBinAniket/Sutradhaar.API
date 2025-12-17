namespace Sutradhaar.API.Models
{
    public class TicketBooking
    {
        public class Ticket
        {
            public int Id { get; set; }
            public required string PassengerName { get; set; }   
            public required string Source { get; set; }
            public required string Destination { get; set; }
            public DateTime TravelDate { get; set; }
            public DateTime ArrivalTime { get; set; }
            public DateTime ReportingTime { get; set; }
            public void SetReportingTime()
            {
                ReportingTime = ArrivalTime.AddMinutes(-15);
            }
            
            // Bus details
            public string? BusNumber { get; set; }
            // Booking info
            public string? Provider { get; set; }
            public required string SeatNumber { get; set; } 
            public required User BookedBy { get; set; }
            public DateTime BookedAt { get; set; } = DateTime.UtcNow;

            // Payment
            public decimal TotalFare { get; set; }
            public string? PaymentStatus { get; set; }   
        }

    }
}
