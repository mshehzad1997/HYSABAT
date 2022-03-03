using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HYSABAT.Models
{
    public class Assest
    {
        [Key]
        public int AssestId { get; set; }
        [Required]
        public string AssetTitle { get; set; }
        [Required]
        public string AssestDescription { get; set; }
        [Required]
        public string AssesImageURL { get; set; }
        public string DashboradTypes { get; set; }
    }
}
