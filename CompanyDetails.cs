using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ValidationDemo.Models
{
    public class CompanyDetails
    {
        [Required]
        [Display(Name ="Enter Company ID: ")]
        public int CompanyID { get; set; }

        [Required]
        [Display(Name = "Enter No of Employees: ")]
        [Range(2, 2000)]

        public int NoOfEmployees { get; set; }

        [Display(Name = "Enter Company Name: ")]
        [MinLength(2,ErrorMessage ="Name should atleast be 2 chr long")]
        public string CompanyName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [EmailAddress(ErrorMessage ="Enter correct Email Address")]
        public string email { get; set; }

        [Url(ErrorMessage ="Enter correct Url")]
        public string url { get; set; }

        [Display(Name = "Enter City: ")]
        public string City { get; set; }

        [Required]
        [RegularExpression(@"([a-zA-Z0-9\s_\\.\-:])+(.png|.jpg|.gif)$", ErrorMessage = "Only Image files allowed.")]
        public HttpPostedFileBase PostedFile { get; set; }

    }
}