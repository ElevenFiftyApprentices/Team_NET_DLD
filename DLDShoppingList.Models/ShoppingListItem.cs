using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLDShoppingList.Models
{
    public enum Priority
    {
        [Description("It can wait")]
        canWait,
        [Description("Need this soon")]
        needSoon,
        Critical
    }
    class ShoppingListItem
    {
        public int Id { get; set; }
        public int ShoppingListId { get; set; }
        public string Contents { get; set; }
        public Priority Priority { get; set; }
        public bool IsChecked { get; set; }
        public DateTimeOffset CreatedUtc { get; set; }
        public DateTimeOffset ModifiedUtc { get; set; }





    }
}
