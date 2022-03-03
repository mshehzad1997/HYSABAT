using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HYSABAT.Models
{
    public class BIDashboard
    {
        public int Id { get; set; }
        [Display(Name = "Sales information")]
        public int? SaleId { get; set; }
        [ForeignKey("SaleId")]
        public virtual SalesInfo SalesInfo { get; set; }
        [Display(Name = "Account Management")]
        public int? AccountId { get; set; }
        [ForeignKey("AccountId")]
        public virtual Account Account { get; set; }
        [Display(Name = "Employee Management")]
        public int? EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }
        [Display(Name = "Help Center")]
        public int? HelpCenterId { get; set; }
        [ForeignKey("HelpCenterId")]
        public virtual Help HelpCenter { get; set; }

        [Display(Name = "Asset Management")]
        public int? AssetId { get; set; }
        [ForeignKey("AssetId")]
        public virtual Assest Asset { get; set; }
        [Display(Name = "Purchase History")]
        public int? PurchaseId { get; set; }
        [ForeignKey("PurchaseId")]
        public virtual Purchase Purchase { get; set; }
    }
}
