namespace Entities.DTOs
{
    public record PostDto

    {
        public string? Title { get; init; }
        public string? Content { get; init; }
        public string? Category { get; init; }
        public string[]? Tags { get; init; }
    }
}
