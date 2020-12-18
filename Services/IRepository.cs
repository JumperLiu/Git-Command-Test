using System;
using System.Collections.Generic;
using Git_Command_Test.Entities;

namespace Git_Command_Test.Services
{
    public interface IRepository
    {
        Item GetItem(Guid id);
        IEnumerable<Item> GetItems();
    }
}