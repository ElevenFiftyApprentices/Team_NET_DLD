using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLDShoppingList.Data
{

    public enum Priority
    {
        [Description("It can wait")]
        canWait,
        [Description("Need Soon")]
        needSoon,
        [Description("Completely Out")]
        empty

    }
    public class ShoppingListItem
    {
        public int ShoppingListItemID { get; set; }

        public int ShoppingListID { get; set; }
        public string Contents { get; set; }
        public string Note { get; set; }
        public Priority Priority { get; set; }
        public bool IsChecked { get; set; }
        public DateTimeOffset CreatedUtc { get; set; }
        public DateTimeOffset ModifiedUtc { get; set; }

        public ShoppingList ShoppingList { get; set; }
    }
}
