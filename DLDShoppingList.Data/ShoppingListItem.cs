using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLDShoppingList.Data
{
    public class ShoppingListItem
    {
        [Key]
        public int Id { get; set; }

        public int ShoppingListId { get; set; }

        [Required]
        public string Content { get; set; }

        public int Priority { get; set; }

        public bool IsChecked { get; set; }

        [Required]
        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset? ModifiedUtc { get; set; }

    }
}
