using LukieannLoanWeb.Data;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LukieannLoanWeb.Models
{
    public class LoanRequestCreateVM
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public int LoanTypeId { get; set; }
        public SelectList? LoanTypes { get; set; }
        public int LoanTermId { get; set; }
        
        public SelectList? LoanTerms { get; set; }

        public double Amount { get; set; }
    }
}
