using System.ComponentModel.DataAnnotations;


namespace SeamlessEscapesBlazor.Models
{
    public class Interest
    {
        [Key]
        public int InterestId { get; set; }

        [Required, StringLength(100)]
        public string InterestName { get; set; }

        [StringLength(300)]
        public string Description { get; set; }
    }
}
