using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLDShoppingList.Models
{
    class ListItem
    {
        public int ShoppingListItemID { get; set; }

        public string Contents { get; set; }

        public string Note { get; set; }

        [UIHint("Starred")]
        public bool IsChecked { get; set; }

        [Display(Name = "Created")]
        public DateTimeOffset CreatedUtc { get; set; }

        public override string ToString() => $"[{ShoppingListItemID}] {Contents}";

    }
}
