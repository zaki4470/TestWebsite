using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TestWebsite.Models.Quote
{
    public class Quote
    {
        [Display(Name = "Title")]
        [Required(ErrorMessage = "Select Title")]
        public List<string> Title { get; set; }
        [Required(ErrorMessage = "Enter Contact Name")]
        [Display(Name = "Contact Name")]
        public string ContactName { get; set; }

        [Required(ErrorMessage = "Enter Email Address")]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }
        [Required(ErrorMessage = "Enter Roof Size")]
        [Display(Name = "Roof Size")]
        public string RoofSize { get; set; }
        [Required(ErrorMessage = "Enter Total Size")]
        [Display(Name = "Total Size (m2)")]
        public double TotalSize { get; set; }

        [Required(ErrorMessage = "Enter Total Rebuild Cost")]
        [Display(Name = "Total Rebuild Cost (£)")]
        public decimal TotalRebuildCost { get; set; }
    }
}
