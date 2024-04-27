using LukieannLoanWeb.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LukieannLoanWeb.Models
{
    public class LoanRequestVM 
    {
        public int Id { get; set; }


        [Display (Name = "LOAN TYPE")]
        public LoanTypeVM? LoanType { get; set; }

        [Display(Name = "LOAN TERM")]
        public LoanTermVM? LoanTerm { get; set; }

        [Display(Name = "STATUS")]
        public LoanStatusVM? LoanStatus { get; set; }

        public string? UserId { get; set; }
        public DateTime? Date { get; set; }
        [Display(Name = "AMOUNT")]
        public decimal Amount { get; set; }

     


    }
}
