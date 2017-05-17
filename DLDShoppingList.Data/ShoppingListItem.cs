using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLDShoppingList.Data
{
    class ShoppingListItem
    {

        public int Id { get; set; }

        public int ShoppingListId { get; set; }

        public string Content { get; set; }

        public int Priority { get; set; }

        public bool IsChecked { get; set; }

        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset ModifiedUtc { get; set; }

    }
}
