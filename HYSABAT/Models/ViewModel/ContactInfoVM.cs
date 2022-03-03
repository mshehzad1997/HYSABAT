using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HYSABAT.Models.ViewModel
{
    public class ContactInfoVM
    {
        [Key]
        public int Id { get; set; }
        public Plans plans { get; set; }
        public enum Plans
        {
            Monthly,
            Yearly
        }
    }
}
