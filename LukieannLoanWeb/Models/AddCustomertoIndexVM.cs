using System.ComponentModel.DataAnnotations;

namespace LukieannLoanWeb.Models
{
    public class AddCustomertoIndexVM : LoanRequestVM
    {
        [Display(Name = "Customer Name")]
        public CustomerVM? User { get; set;}
    }
}
