using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaxiVer.Web.Data.Entities
{
    public class TaxiEntity
    {
        public int Id { get; set; }

        [StringLength(6, MinimumLength = 6, ErrorMessage = "The {0} field must have {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [RegularExpression(@"^([A-Za-z]{3}\d{3})$", ErrorMessage = "The field {0} must starts with three characters and ends with three numbers.")]
        public string Plaque { get; set; }
    }
}
