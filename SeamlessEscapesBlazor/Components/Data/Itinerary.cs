using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace SeamlessEscapesBlazor.Models
{
    public class Itinerary
    {
        [Key]
        public int ItineraryId { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public List<Activity> Activities { get; set; } = new List<Activity>();
        public List<Hotel> Hotels { get; set; } = new List<Hotel>();
        public List<Transport> Transports { get; set; } = new List<Transport>();
    }
}
