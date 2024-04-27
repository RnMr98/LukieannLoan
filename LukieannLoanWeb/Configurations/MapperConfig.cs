using AutoMapper;
using LukieannLoanWeb.Data;
using LukieannLoanWeb.Models;
namespace LukieannLoanWeb.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap< LoanType, LoanTypeVM > ().ReverseMap();
            CreateMap< LoanTerm, LoanTermVM > ().ReverseMap();
            CreateMap< LoanRequest, LoanRequestCreateVM> ().ReverseMap();
            CreateMap< LoanRequest, LoanRequestVM > ().ReverseMap();
            CreateMap<LoanStatus, LoanStatusVM>().ReverseMap();
        }


    }
}
