using System.ComponentModel.DataAnnotations;

namespace AndiClinic.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }
        public string Condition { get; set; }
        public bool Active { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;

    }
}
