using System;
using System.Collections.Generic;
using System.Linq;
using Git_Command_Test.Entities;
using Git_Command_Test.Services;

namespace Git_Command_Test.Repositoies
{
    public class InMemoryItemsRepository : IRepository
    {
        // private readonly List<Item> _items = new()
        // {
        //     new Item { Id = Guid.NewGuid(), Name = "Product1", Price = 15.5m, CreatedDate = DateTimeOffset.Now },
        //     new Item { Id = Guid.NewGuid(), Name = "Product2", Price = 25.8m, CreatedDate = DateTimeOffset.Now },
        //     new Item { Id = Guid.NewGuid(), Name = "Product3", Price = 10.5m, CreatedDate = DateTimeOffset.Now },
        //     new Item { Id = Guid.NewGuid(), Name = "Product4", Price = 5.9m, CreatedDate = DateTimeOffset.Now },
        //     new Item { Id = Guid.NewGuid(), Name = "Product5", Price = 17.2m, CreatedDate = DateTimeOffset.Now }
        // };
        private readonly List<Item> _items = new();

        public InMemoryItemsRepository()
        {
            for (int i = 1, max = 10; i < max; i++)
            {
                _items.Add(new Item
                {
                    Id = Guid.NewGuid(),
                    FirstName = $"Product{i}",
                    LastName = $".L{i}N",
                    Price = new Random().Next(i, i * max) / (decimal)max,
                    CreatedDate = DateTimeOffset.Now
                });
            }
        }

        public IEnumerable<Item> GetItems() => _items;

        public Item GetItem(Guid id) => _items.Where(i => i.Id == id).SingleOrDefault();
    }
}