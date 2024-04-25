using LukieannLoanWeb.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using LukieannLoanWeb.Models;
using LukieannLoanWeb.Data;

namespace LukieannLoanWeb.Configurations.Entities
{
    public class ParishSeederConfiguration : IEntityTypeConfiguration<Parish>
    {
        public void Configure(EntityTypeBuilder<Parish> builder)
        {
            builder.HasData(
                new Parish
                {
                    Id = 1,
                    Name = Parishes.Parish1,
                },
                 new Parish
                 {
                     Id = 2,
                     Name = Parishes.Parish2,
                 },
                  new Parish
                  {
                      Id = 3,
                      Name = Parishes.Parish3,
                  },
                   new Parish
                   {
                       Id = 4,
                       Name = Parishes.Parish4,
                   },
                    new Parish
                    {
                        Id = 5,
                        Name = Parishes.Parish5,
                    },

                new Parish
                {
                    Id = 6,
                    Name = Parishes.Parish6,
                },
                new Parish
                {
                    Id = 7,
                    Name = Parishes.Parish7,
                },
               new Parish
               {
                   Id = 8,
                   Name = Parishes.Parish8,
               },
                new Parish
                {
                    Id = 9,
                    Name = Parishes.Parish9,
                },
               new Parish
               {
                   Id = 10,
                   Name = Parishes.Parish10,
               },
                 new Parish
                 {
                     Id = 11,
                     Name = Parishes.Parish11,
                 },
              new Parish
              {
                  Id = 12,
                  Name = Parishes.Parish12,
              },
                new Parish
                {
                    Id = 13,
                    Name = Parishes.Parish13,
                },
                new Parish
                {
                    Id = 14,
                    Name = Parishes.Parish14,
                }

                );
        }
    }
}
