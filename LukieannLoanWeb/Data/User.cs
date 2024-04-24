using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace LukieannLoanWeb.Data
{
    public class User : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string? TRN { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? City { get; set; }
        public Parish? Parish { get; set; }
        public int? ParishId { get; set; }
        public DateTime? DateJoined { get; set; }


    }
}
