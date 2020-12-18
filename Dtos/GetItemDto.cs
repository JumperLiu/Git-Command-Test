using System;

namespace Git_Command_Test.Dtos
{
    public record GetItemDto
    {
        public Guid Id { get; init; }
        public string FullName { get; init; }
        public decimal Price { get; init; }
        public DateTimeOffset CreatedDate { get; init; }
        public DateTimeOffset? ModifiedDate { get; set; }
    }
}