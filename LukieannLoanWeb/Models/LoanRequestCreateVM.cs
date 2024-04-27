using LukieannLoanWeb.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace LukieannLoanWeb.Models
{
    public class LoanRequestCreateVM
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        [Display(Name = "LOAN TYPE")]
        public int LoanTypeId { get; set; }

        public SelectList? LoanTypes { get; set; }
        [Display(Name = "LOAN TERM")]
        public int LoanTermId { get; set; }
        
        public SelectList? LoanTerms { get; set; }
        [Display(Name = "AMOUNT")]
        public decimal Amount { get; set; }

        [Display(Name = "STATUS")]
        public int LoanStatusId { get; set; }

        public SelectList? LoanStatus { get; set; }
    }
}
