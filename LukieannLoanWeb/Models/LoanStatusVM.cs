using System.ComponentModel.DataAnnotations;

namespace LukieannLoanWeb.Models
{
    public class LoanStatusVM
    {

        [Display(Name = "STATUS")]
        public int Id { get; set; }
        public string? Status { get; set; }
    }
}
