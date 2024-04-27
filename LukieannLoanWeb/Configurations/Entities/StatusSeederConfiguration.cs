using LukieannLoanWeb.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using LukieannLoanWeb.Data;

namespace LukieannLoanWeb.Configurations.Entities
{
    public class StatusSeederConfiguration : IEntityTypeConfiguration<LoanStatus>
    {
            public void Configure(EntityTypeBuilder<LoanStatus> builder)
            {
                builder.HasData(
                    new LoanStatus
                    {
                        Id = 1,
                        Status = Status.Status1,
                    },
                    new LoanStatus
                    {
                        Id = 2,
                        Status = Status.Status2,
                    },
                    new LoanStatus
                    {
                        Id = 3,
                        Status = Status.Status3,
                    }

                    );
            }
        }
}

      


                