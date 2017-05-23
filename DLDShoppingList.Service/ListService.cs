using DLDShoppingList.Data;
using DLDShoppingList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLDShoppingList.Service
{
    class ListService
    {
        public bool CreateList(ListCreate model)
        {
            var entity = new ShoppingList
            {
                Name = model.Name,
                Color = model.Color,
                CreatedUtc = DateTimeOffset.UtcNow
            };

            using (var ctx = new ApplicationDbContext()) 
            {
                ctx.ShoppingList.Add(entity);

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteItem(int itemId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.ShoppingListItem.Single
                    (e => e.ShoppingListItemID == itemId);

                ctx.ShoppingListItem.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
