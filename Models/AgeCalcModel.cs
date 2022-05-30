using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FirstResponsiveWebAppSanders.Models
{
    public class AgeCalcModel
    {
        [Required(ErrorMessage="Please enter a name.")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Please enter a birth year.")]
        [Range(1900, 2022, ErrorMessage = "Please enter a birth year between 1900 and 2022.")]
        public int? BirthYear { get; set; }
        public string AgeThisYear()
        {
            const int CURRENTYEAR = 2022;
            int? EndAge = CURRENTYEAR - BirthYear;
            return Name + " will be " + EndAge.ToString() + " years old by December 31st, 2022";
        }
    }
}
