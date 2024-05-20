using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SeamlessEscapesBlazor.Models
{
    public abstract class Transport
    {
        [Key]
        public int TransportId { get; set; }

    }

}
