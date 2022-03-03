using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HYSABAT.Models.ViewModel
{
    public class AssetManagement
    {
        public int Id { get; set; }
        [Required]
        [RegularExpression(@"^(([A-za-z]+[\s]{1}[A-za-z]+)|([A-Za-z]+))$")]
        [StringLength(20)]
        public string Title { get; set; }
        [Required]
        [RegularExpression(@"^(([A-za-z]+[\s]{1}[A-za-z]+)|([A-Za-z]+))$")]
        [StringLength(100)]
        public string Description { get; set; }
        [Required]
        public IFormFile FileImage { get; set; }
        public string ImageURL { get; set; }
        public string Dashboards { get; set; }
    }
    
}
