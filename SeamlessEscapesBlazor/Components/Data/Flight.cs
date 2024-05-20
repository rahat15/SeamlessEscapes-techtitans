using System.ComponentModel.DataAnnotations;

namespace SeamlessEscapesBlazor.Models
{
    public class Flight : Transport
    {
        [Required, StringLength(50)]
        public string FlightNumber { get; set; }

        [StringLength(100)]
        public string Airline { get; set; }

        // Assuming additional properties from your class diagram that might include:
        [Required]
        public DateTime DepartureTime { get; set; }

        [Required]
        public DateTime ArrivalTime { get; set; }

        [Required, StringLength(100)]
        public string DepartureAirport { get; set; }

        [Required, StringLength(100)]
        public string ArrivalAirport { get; set; }

        // Example of additional optional property
        [StringLength(500)]
        public string Description { get; set; } // Details about the flight
    }
}
