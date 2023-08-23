using System.ComponentModel.DataAnnotations;

namespace Commander.Models{
    public class Command{
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(250)]
        public string HowTo { get; set; } = default!;
        [Required]
        public string Line { get; set; } = default!;
        [Required]
        public string Platform { get; set; } = default!;
    }
}