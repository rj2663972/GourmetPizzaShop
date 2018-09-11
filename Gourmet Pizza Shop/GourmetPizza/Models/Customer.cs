using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GourmetPizza.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }

        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$", ErrorMessage = "Family name can contain alphabets, hyphen and  apostrophe only")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Number of characters in Family Name should be between 2 and 20")]
        public String FamilyName { get; set; }

        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$", ErrorMessage = "Given name can contain alphabets, hyphen and  apostrophe only")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Number of characters in Given Name should be between 2 and 20")]
        public String GivenName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name ="Date of Birth")]
        [Required]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "Email Address is required!")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email addres is not valid!")]
        public String Email { get; set; }

        [Required(ErrorMessage = "Mobile Number is required!")]
        [RegularExpression("04[0-9][0-9][' '][0-9][0-9][0-9][' '][0-9][0-9][0-9]"
            , ErrorMessage = "Mobile number should match the pattern '04xx xxx xxx'")]
        public String Mobile { get; set; }

        [Required]
        [RegularExpression("[0-8]{4}", ErrorMessage = "Postal Code should be exaclty of 4 digits and for the resedential purpose, it cannot start start with 9")]
        public String PostalCode { get; set; }
    }
}
