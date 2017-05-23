using DLDShoppingList.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLDShoppingList.Data
{
    public class ShoppingListItemContext
    {
        public int ShoppingListItemContextID { get; set; }

        public int ShoppingListContextID { get; set; }
        public string Contents { get; set; }
        public string Note { get; set; }
        public Priority Priority { get; set; }
        public bool IsChecked { get; set; }
        public DateTimeOffset CreatedUtc { get; set; }
        public DateTimeOffset ModifiedUtc { get; set; }

        public ShoppingListContext ShoppingList { get; set; }
    }
}
