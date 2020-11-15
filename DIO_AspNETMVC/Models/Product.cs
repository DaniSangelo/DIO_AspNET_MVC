using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DIO_AspNETMVC.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Product name must be informed")]
        public string Name { get; set; }
        [Range(0, 9999, ErrorMessage = "Quantity must be between 0 and 9999")]
        public double Quantity { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
