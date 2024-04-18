using LukieannLoanWeb.Data;

namespace LukieannLoanWeb.Models
{
    public class LoanRequestVM 
    {
        public int Id { get; set; }

        public LoanTypeVM LoanType { get; set; }
        public LoanTermVM LoanTerm { get; set; }
        public string? UserId { get; set; }
        public DateTime? Date { get; set; }
        public double Amount { get; set; }
        public bool? Approved { get; set; }
        public bool? Cancelled { get; set; }
    }
}
