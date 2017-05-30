using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLDShoppingList.Data
{
    public class ShoppingList
    {
        [Key]
        public int ShoppingListID { get; set; }

        [Display(Name = "List Name")]
        public string Name { get; set; }
        public string Color { get; set; }

        [Display(Name = "Created")]
        public DateTimeOffset CreatedUtc { get; set; }

        [Display(Name = "Modified")]
        public DateTimeOffset ModifiedUtc { get; set; }

        public virtual ICollection<ShoppingListItem> ShoppingListItems { get; set; }
    }
}
