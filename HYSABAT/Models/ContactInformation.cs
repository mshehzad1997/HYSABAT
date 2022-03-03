using HYSABAT.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HYSABAT.Models
{
    public class ContactInformation
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "First Name")]
     
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Company Name")]
        public string Company { get; set; }
        [Required]
        [Display(Name = "Number Of Branches")]
        public int NumberOfBranches { get; set; }
        [Required]
        [Display(Name = "Number Of Users")]
        public int NumberOfUser { get; set; }
      
        [Display(Name = "Position")]
        public string Postion { get; set; }
        [Required]
        [Display(Name = "CR Number")]
        public string CRNumber { get; set; }
        [Required]
        [Display(Name = "Number Of Customer")]
        public int NumberOfCustomer { get; set; }
      
        [Display(Name = "Number Of Supplier")]
        public int NumberOfSupliers { get; set; }
       
        [Required]
        [Display(Name = "Country")]
        public string Country { get; set; }
        [Required]
        [Display(Name = "Address")]
        public string Address { get; set; }
        [Required]
        [Display(Name = "City")]
        public string City { get; set; }
        [Required]
        [Display(Name = "State")]
        public string State { get; set; }
        public int Postal_ZipCode { get; set; }
        [Required]
        [Display(Name = " Name On Credit Card ")]
        public string NameOnCard { get; set; }
       
        [Display(Name = " Name On Credit Card ")]
        public string CreditCardNumber { get; set; }
        
        public DateTime ExpiryDate { get; set; }
        [Required]
        [Display(Name = "CVC ")]
        public string CVC { get; set; }
        [Display(Name ="Pricing Plan")]
        public int? PricingPlanId { get; set; }
        [ForeignKey("PricingPlanId")]
        public virtual PricingPlan PricingPlan { get; set; }
        public Plans plans { get; set; }
        public bool AutoRenew { get; set; }
        public enum Plans
        {
            Monthly,
            Yearly
        }
      
        
    }
}
