using DLDShoppingList.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLDShoppingList.Data
{
    public class ShoppingListContext
    {
        public int ShoppingListContextID { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public DateTimeOffset CreatedUtc { get; set; }
        public DateTimeOffset ModifiedUtc { get; set; }

        public virtual ICollection<ShoppingListItemContext> ShoppingListItems { get; set; }
    }
}
