using System.ComponentModel.DataAnnotations;

namespace SeamlessEscapes.Models
{
    public class Road
    {
        [Required, StringLength(100)]
        public string RoadTransportType { get; set; } // e.g., Bus, Car Rental
    }
}
