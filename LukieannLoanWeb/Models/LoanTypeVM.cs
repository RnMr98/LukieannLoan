using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using LukieannLoanWeb.Data;

namespace LukieannLoanWeb.Models
{
    public class LoanTypeVM
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "LOAN NAME")]
        public string? Name { get; set; }

        [Required]
        [Display(Name="INTEREST RATE")]
        public decimal? Interest { get; set; }
    }
}
