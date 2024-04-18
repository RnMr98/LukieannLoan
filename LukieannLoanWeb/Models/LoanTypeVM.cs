using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using LukieannLoanWeb.Data;

namespace LukieannLoanWeb.Models
{
    public class LoanTypeVM
    {
        public int Id { get; set; }
        [Required]

        public string? Name { get; set; }

        [Required]
        [Display(Name="Interest Rate")]
        public int Interest { get; set; }
    }
}
