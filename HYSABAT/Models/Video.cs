using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HYSABAT.Models
{
    public class Video
    {
        [Key]
        public int Id { get; set; }
        public string VideoName { get; set; }
        public string VideoPath { get; set; }
    }
}
