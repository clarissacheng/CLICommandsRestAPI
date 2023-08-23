namespace Commander.Dtos{
    public class CommandReadDto{
        public int Id { get; set; }

        public string HowTo { get; set; } = default!;

        public string Line { get; set; } = default!;
    }
}