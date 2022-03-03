using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HYSABAT.Models
{
    public class PricingPlan
    {
        [Key]
        public int Id { get; set; }

        public string PricingPlanTitle { get; set; }

        public int PricingPlanMonthlyPrice { get; set; }

        public int PricingPlanYearlyPrice { get; set; }

        
        public string PricingPlanImageURL { get; set; }
       
        public string planfeatures1 { get; set; }
       
        public string planfeatures2 { get; set; }
       
        public string planfeatures3 { get; set; }
     
        public string planfeatures4 { get; set; }
       
        public string planfeatures5 { get; set; }
       
    }
}
