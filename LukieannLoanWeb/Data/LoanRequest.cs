
using LukieannLoanWeb.Constants;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LukieannLoanWeb.Data
{
    public class LoanRequest
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public string? UserId { get; set; }
        public LoanType? LoanType { get; set; }
        public int? LoanTypeId { get; set; }
        public LoanTerm? LoanTerm { get; set; }
        public int? LoanTermID { get;set; }
        public decimal? Amount { get; set; }
        public LoanStatus? LoanStatus { get; set; }
        public int? LoanStatusId { get; set; }

        public User? User { get; set; }
    }
}
