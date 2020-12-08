using MenuitemService.Controllers;
using MenuitemService.Models;
using System.Collections.Generic;

namespace MenuitemService.Repository
{
    public class ItemRepository : IItemRepository
    {
        /*private readonly TicketDbContext dbContext;

        public TicketRepository(TicketDbContext _dbContext)
        {
            this.dbContext = _dbContext;
        }*/
        public List<Item> Itemlist = new List<Item>();
        public ItemRepository()
        {
            Itemlist.Add(new Item { Item_Id = 1,Item_Name="Sandwich", Cost = 100, Category="Main Course" });
            Itemlist.Add(new Item { Item_Id = 2, Item_Name = "French Fries", Cost = 57, Category = "Staters" });
            Itemlist.Add(new Item { Item_Id = 3, Item_Name = "Browine", Cost = 62, Category = "Dessert" });
            Itemlist.Add(new Item { Item_Id = 4, Item_Name = "Burger", Cost = 80, Category = "Main Course" });
            Itemlist.Add(new Item { Item_Id = 5, Item_Name = "Icecream", Cost = 35, Category = "Dessert" });
        }

        public IEnumerable<Item> GetAll()
        {
            //var booklist = dbContext.Tickets.ToList();
            return Itemlist;
        }
        public Item GetById(int ticket_id)
        {
            foreach (var t in Itemlist)
            {
                if (t.Item_Id == ticket_id)
                {
                    return t;
                }
            }
            return null;
        }
    }
}
