using LukieannLoanWeb.Configurations;
using LukieannLoanWeb.Configurations.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LukieannLoanWeb.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new RoleSeedConfiguration());
            builder.ApplyConfiguration(new UserSeedConfiguration());
            builder.ApplyConfiguration(new UserRoleSeedConfiguration());
            builder.ApplyConfiguration(new TermsSeederConfiguration());
            builder.ApplyConfiguration(new ParishSeederConfiguration());
            builder.ApplyConfiguration(new StatusSeederConfiguration());

        }

        public DbSet<LoanStatus> LoanStatuses { get; set; }
        public DbSet<LoanTerm> LoanTerms { get; set; }
        public DbSet<LoanType> LoanTypes { get; set; }
        public DbSet<LoanRequest> LoanRequests { get; set; }
        public DbSet<Parish> Parishes { get; set; }
    }
}
