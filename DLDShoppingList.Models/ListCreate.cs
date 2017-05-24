using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLDShoppingList.Models
{
    public class ListCreate
    {
        [Required]
        [MinLength(2,ErrorMessage = "Name must be more than 2 characters.")]
        [MaxLength(128)]
        public string Name { get; set; }

        public string Color { get; set; }
    }
}
