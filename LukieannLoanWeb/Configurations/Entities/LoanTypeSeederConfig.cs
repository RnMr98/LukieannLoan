using LukieannLoanWeb.Data;
using LukieannLoanWeb.Constants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LukieannLoanWeb.Configurations.Entities
{
    public class LoanTypeSeederConfig : IEntityTypeConfiguration<LoanType>
    {
        public void Configure(EntityTypeBuilder<LoanType> builder)
        {
            builder.HasData(
                new LoanType
                {
                    Id = 1,
                    Name = LoanTypes.PersonalName,
                    Interest = LoanTypes.PersonalIntrest

                },
                new LoanType
                {
                    Id = 2,
                    Name = LoanTypes.AutoName,
                    Interest = LoanTypes.AutoIntrest
                },
                new LoanType
                {
                    Id = 3,
                    Name = LoanTypes.MortgageName,
                    Interest = LoanTypes.MortgageIntrest
                },
                new LoanType
                {
                    Id = 4,
                    Name = LoanTypes.StudentName,
                    Interest= LoanTypes.StudentIntrest
                },
                new LoanType
                {
                    Id= 5,
                    Name = LoanTypes.PayDayName,
                    Interest=LoanTypes.PayDayIntrest
                }
                );
        }
    }
}
