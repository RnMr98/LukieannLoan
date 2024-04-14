using AutoMapper;
using LukieannLoanWeb.Data;
using LukieannLoanWeb.Models;
namespace LukieannLoanWeb.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap< LoanTypeVM, LoanType > ().ReverseMap();
        }


    }
}
