using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HYSABAT.Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }
      
        public string AccountTitle { get; set; }
       
        public string AccountDescription { get; set; }
       
        public string AccountImagePath { get; set; }
        public string DashboradTypes { get; set; }
      
    }
}
