using System;
using System.Collections.Generic;
<<<<<<< HEAD
=======
using System.ComponentModel;
>>>>>>> b6d6a225575d2f882a81df8a74c524011b43332f
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
<<<<<<< HEAD
        public string ListName { get; set; }

        public string ListColor { get; set; }
=======
        public string Content { get; set; }

        [DefaultValue(false)]
        public bool IsChecked { get; set; }
>>>>>>> b6d6a225575d2f882a81df8a74c524011b43332f

        [Required]
        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset? ModifiedUtc { get; set; }

    }
}
