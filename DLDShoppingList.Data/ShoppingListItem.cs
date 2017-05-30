using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLDShoppingList.Data;

namespace DLDShoppingList.Data
{

    public enum Priority
    {
        [Display(Name="It can wait")]
        canWait,
        [Display(Name="Need Soon")]
        needSoon,
        [Display(Name="Completely Out")]
        empty

    }
    public class ShoppingListItem
    {
        public int ShoppingListItemID { get; set; }

        
        public int ShoppingListID { get; set; }
        public string Contents { get; set; }
        public string Note { get; set; }
        public Priority Priority { get; set; }

        [Display(Name = "Checked")]
        public bool IsChecked { get; set; }

        [Display(Name = "Created")]
        public DateTimeOffset CreatedUtc { get; set; }

        [Display(Name = "Modified")]
        public DateTimeOffset ModifiedUtc { get; set; }

        public virtual ShoppingList ShoppingList { get; set; }


    }
}
