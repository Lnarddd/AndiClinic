using System.ComponentModel.DataAnnotations;

namespace AndiClinic.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Password { get; set; }
        public string Username { get; set; }
    }
}
