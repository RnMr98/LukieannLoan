﻿using LukieannLoanWeb.Data;
using System.ComponentModel.DataAnnotations;

namespace LukieannLoanWeb.Models
{
    public class LoanRequestVM 
    {
        public int Id { get; set; }
        [Display (Name = "Loan Type")]

        public LoanTypeVM? LoanType { get; set; }

        [Display(Name = "Loan Term")]
        public LoanTermVM? LoanTerm { get; set; }
        public string? UserId { get; set; }
        public DateTime? Date { get; set; }
        public decimal Amount { get; set; }
        public bool? Approved { get; set; }
        public bool? Cancelled { get; set; }
    }
}
