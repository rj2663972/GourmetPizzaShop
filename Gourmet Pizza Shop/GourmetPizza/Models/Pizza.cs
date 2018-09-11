using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GourmetPizza.Models
{
    public class Pizza
    {
        [Required]
        public int ID { get; set; }

        [Required(ErrorMessage = "Pizza name is required!")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""\s_]*$", ErrorMessage = "Pizza name can contain alphabets, digits, spaces and underscores only")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Number of characters in Pizza Name should be between 3 and 20")]
        public String Name { get; set; }

        [Required]
        private double price;

        [Required(ErrorMessage = "Price is required!")]
        [Display(Name = "Price Each")]
        [DataType(DataType.Currency)]
        [Range(typeof(double), "5.00", "20.00", ErrorMessage = "The pizza price should be in the range from $5.00 to $20.00")]
        public double Price { get => Math.Round(price, 2); set => price = value; }
    }
}
