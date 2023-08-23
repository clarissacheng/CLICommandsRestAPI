using System.ComponentModel.DataAnnotations;

namespace Commander.Dtos{
    public class CommandCreateDto{
        [Required]
        [MaxLength(250)]
        public string HowTo { get; set; } = default!;

        [Required]
        public string Line { get; set; } = default!;
        [Required]
        public string Platform { get; set; } = default!;
    }
}