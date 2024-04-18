namespace LukieannLoanWeb.Data
{
    public class LoanRequest
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public string UserId { get; set; }
        public LoanType LoanType { get; set; }
        public int LoanTypeId { get; set; }
        public LoanTerm LoanTerm { get; set; }
        public int LoanTermID { get;set; }
        public double Amount { get; set; }
    }
}
