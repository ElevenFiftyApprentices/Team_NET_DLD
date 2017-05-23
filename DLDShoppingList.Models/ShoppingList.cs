using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLDShoppingList.Models

{
    public class ShoppingList
    {
        public int ShoppingListID { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public DateTimeOffset CreatedUtc { get; set; }
        public DateTimeOffset ModifiedUtc { get; set; }

        public ICollection<ShoppingListItem> ShoppingListItems { get; set; }
    }
}
