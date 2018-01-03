using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DentalSelect.Web.DAL
{
    public class Subscriber
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(128)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(128)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [MaxLength(32)]
        public string State { get; set; }
        [Required]
        [MaxLength(16)]
        [Display(Name = "Zip Code")]
        [DataType(DataType.PostalCode)]
        [RegularExpression(@"^(?!00000)[0-9]{5,5}$", ErrorMessage = "The Zip code should contain 5 digits and should not be 00000.")]
        public string ZipCode { get; set; }
    }
}