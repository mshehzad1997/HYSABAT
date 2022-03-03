using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HYSABAT.Models.VideoViewModel
{
    public class VideoVM
    {
        [Key]
        public int Id { get; set; }
        [Required]

        public string VName { get; set; }
        [Required]
        public IFormFile FileVideo { get; set; }
        public string videourl { get; set; }
    }
}
