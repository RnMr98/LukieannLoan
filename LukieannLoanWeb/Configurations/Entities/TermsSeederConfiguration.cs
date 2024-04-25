using LukieannLoanWeb.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using LukieannLoanWeb.Models;
using LukieannLoanWeb.Data;

namespace LukieannLoanWeb.Configurations.Entities
{
    public class TermsSeederConfiguration : IEntityTypeConfiguration<LoanTerm>
    {
        public void Configure(EntityTypeBuilder<LoanTerm> builder)
        {
            builder.HasData(
                new LoanTerm
                {
                    Id = 1,
                    Term = Terms.ThreeMonths,
                },
                new LoanTerm
                {
                    Id = 2,
                    Term = Terms.sixMonths,
                },
                new LoanTerm
                {
                    Id = 3,
                    Term = Terms.TwelveMonths,
                },
                new LoanTerm
                {
                    Id = 4,
                    Term = Terms.EigthteenMonths,
                },
                new LoanTerm
                {
                    Id = 5,
                    Term = Terms.TwelveMonths,
                },
                new LoanTerm
                {
                    Id = 6,
                    Term = Terms.ThirtyMonths,
                },
                  new LoanTerm
                  {
                      Id = 7,
                      Term = Terms.ThirtysixMonths,
                  },
                new LoanTerm
                {
                    Id = 8,
                    Term = Terms.ForthyeigthMonths,
                },
                new LoanTerm
                {
                    Id = 9,
                    Term = Terms.SixtyMonths,
                }

                );
        }
    }
}
