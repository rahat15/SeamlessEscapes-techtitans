using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SeamlessEscapesBlazor.Models
{
    public class Activity
    {
        [Key]
        public int ActivityId { get; set; }

        [Required, StringLength(200)]
        public string ActivityName { get; set; }

        [StringLength(500)]
        public string Description { get; set; }
    }
}
