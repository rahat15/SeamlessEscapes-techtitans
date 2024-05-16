using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SeamlessEscapes.Models
{
    public class Hotel
    {
        [Key]
        public int HotelId { get; set; }

        [Required, StringLength(200)]
        public string HotelName { get; set; }

        [StringLength(300)]
        public string Address { get; set; }

        [Required]
        public double PricePerNight { get; set; }
    }
}

