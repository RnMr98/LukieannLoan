using System.ComponentModel.DataAnnotations;

namespace LukieannLoanWeb.Models
{
    public class LoanTermVM
    {
        public int ID { get; set; }

        [Display(Name = "LOAN TERM")]
        public decimal? Term { get; set; }
    }
}
