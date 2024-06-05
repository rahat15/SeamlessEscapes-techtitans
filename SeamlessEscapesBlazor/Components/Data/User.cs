/*using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SeamlessEscapesBlazor.Models
{
    public class User
    {
        [Key] public int UserId { get; set; }

        [Required, StringLength(100)] public string Username { get; set; }

        [Required, StringLength(255)] public string Email { get; set; }

        [Required, StringLength(255)] public string Password { get; set; } // Securely hash passwords before storing

        /*[StringLength(100)] public string FirstName { get; set; }

        [StringLength(100)] public string LastName { get; set; }

        [StringLength(15)] public string PhoneNumber { get; set; }

        [StringLength(300)] public string Address { get; set; }#1#
    }
}*/

namespace SeamlessEscapesBlazor.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Email { get; set; } // Ensure this is not nullable
        public string Password { get; set; }
        public int UserID { get; set; }
    }
}
