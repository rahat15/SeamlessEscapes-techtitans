using System;
using System.ComponentModel.DataAnnotations;

namespace SeamlessEscapesBlazor.Models
{
    public class Flight
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string FlightNumber { get; set; }

        [StringLength(100)]
        public string Airline { get; set; }

        [Required]
        public DateTime DepartureTime { get; set; }

        [Required]
        public DateTime ArrivalTime { get; set; }

        [StringLength(500)]
        public string Description { get; set; }
    }
}