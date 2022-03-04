using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HYSABAT.Models.PlanViewModel
{
    public class PricingPlanVM
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Bussiness Plan ")]
       
      
        public string Title { get; set; }
        [Required]
        [Display(Name = "Monthly Price")]
        public int MonthlyPrice { get; set; }
        [Required]
        [Display(Name = "Yearly Price")]
        public int YearlyPrice { get; set; }
        [Required]
      
        public IFormFile FileImage { get; set; }
        public string ImageURL { get; set; }
       
        public string planfeatures1 { get; set; }
        
        public string planfeatures2 { get; set; }
      
        public string planfeatures3 { get; set; }
        
        public string planfeatures4 { get; set; }
       
        public string planfeatures5 { get; set; }
        public string planfeatures6 { get; set; }
    }
}
