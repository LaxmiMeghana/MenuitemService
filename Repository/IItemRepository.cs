using MenuitemService.Models;
using System.Collections.Generic;

namespace MenuitemService.Repository
{
    public interface IItemRepository
    {
        IEnumerable<Item> GetAll();

        Item GetById(int ticket_id);
    }
}
