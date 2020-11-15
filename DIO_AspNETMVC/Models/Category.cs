using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DIO_AspNETMVC.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Category name must be informed")]
        public string Name { get; set; }

        public List<Product> Products { get; set; }
    }
}
