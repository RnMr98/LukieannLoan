using LukieannLoanWeb.Data;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace LukieannLoanWeb.Models
{
    public class CustomerVM
    {
        public int Id { get; set; }
        public string TRN { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Middle Name")]
        public string? MiddleName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Address1 { get; set; }
        public string? Address2 { get; set; }
        public string City { get; set; }
        public Parish Parish { get; set; }
        [Display(Name = "Parish")]
        public int? ParishId { get; set; }
        [Display(Name = "Date Of Birth")]
        public DateTime DateOfBirth { get; set; }
    }
}
