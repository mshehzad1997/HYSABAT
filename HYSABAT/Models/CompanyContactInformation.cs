using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HYSABAT.Models
{
    public class CompanyContactInformation
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string CompanyLocation { get; set; }
        public string CompanyPhone { get; set; }
        public string Email { get; set; }
    }
}
