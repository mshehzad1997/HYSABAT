using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace HYSABAT.Models.ViewModel
{
    public class AccountManagement
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Account Management title is required")]
        
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Account Management discription is required")]
       
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Please choose logo image")]
       [NotMapped]
        public IFormFile ImageFile { get; set; }
        public string ImagePath { get; set; }
       public string Dashboards { get; set; }

    }
}
