using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DLDShoppingList.Service
{
    public class ListService
    {
  

        public bool DeleteshoppingList(int ItemId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                      ctx
                      .Item
                      .Single(e => e.ItemID == ItemId);

                ctx.Notes.Remove(entity);

                return ctx.SaveChanges() == 1;

            }
        }

    }
}
