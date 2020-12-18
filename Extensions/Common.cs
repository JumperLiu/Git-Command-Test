using Git_Command_Test.Dtos;
using Git_Command_Test.Entities;

namespace Git_Command_Test.Extensions
{
    public static class Common
    {
        public static GetItemDto AsGetDto(this Item item) => new GetItemDto()
        {
            Id = item.Id,
            FullName = $"{item.FirstName}{item.LastName}",
            Price = item.Price,
            CreatedDate = item.CreatedDate,
            ModifiedDate = item.ModifiedDate
        };
    }
}