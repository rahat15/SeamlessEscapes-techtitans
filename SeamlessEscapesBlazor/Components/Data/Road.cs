using System.ComponentModel.DataAnnotations;


namespace SeamlessEscapesBlazor.Models
{
    public class Road : Transport
    {
        [Required, StringLength(100)]
        public string RoadTransportType { get; set; } // e.g., Bus, Car Rental
    }
}
