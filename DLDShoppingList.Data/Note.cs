using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLDShoppingList.Data
{
    class Note
    {

        public int Id { get; set; }

        public int ShoppingListItemId { get; set; }

        public string Body { get; set; }

        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset ModifiedUtc { get; set; } 

    }
}
