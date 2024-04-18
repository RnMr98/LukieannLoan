namespace LukieannLoanWeb.Models
{
    public class LoanViewVM
    {
        public LoanViewVM(List<LoanRequestVM> loanRequests)
        {
            LoanRequests = loanRequests;
        }


        public List<LoanRequestVM> LoanRequests { get; set; }
    }
}
