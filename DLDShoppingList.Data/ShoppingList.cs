using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLDShoppingList.Data
{
    public class ShoppingList
    {
        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }

        [Required]
        public string ListName { get; set; }

        public string ListColor { get; set; }

        [Required]
        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset? ModifiedUtc { get; set; }

    }
}
