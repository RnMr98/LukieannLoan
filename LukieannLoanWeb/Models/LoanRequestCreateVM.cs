using LukieannLoanWeb.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace LukieannLoanWeb.Models
{
    public class LoanRequestCreateVM
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        [Display(Name = "Loan Type")]
        public int LoanTypeId { get; set; }

        public SelectList? LoanTypes { get; set; }
        [Display(Name = "Loan Term")]
        public int LoanTermId { get; set; }
        
        public SelectList? LoanTerms { get; set; }

        public decimal Amount { get; set; }
    }
}
