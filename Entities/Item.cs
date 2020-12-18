using System;

namespace Git_Command_Test.Entities
{
    public record Item
    {
        public Guid Id { get; init; }
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public decimal Price { get; init; }
        public DateTimeOffset CreatedDate { get; init; }
        public DateTimeOffset? ModifiedDate { get; set; }
    }
}