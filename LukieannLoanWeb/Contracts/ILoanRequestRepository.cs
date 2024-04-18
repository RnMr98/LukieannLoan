using LukieannLoanWeb.Data;
using LukieannLoanWeb.Models;

namespace LukieannLoanWeb.Contracts
{
    public interface ILoanRequestRepository : IGenericRepository<LoanRequest>
    {
        public Task CreateLoanRequest(LoanRequestCreateVM model);
        Task<LoanViewVM> GetMyLoanDetails();
        Task<List<LoanRequest>> GetAllAsync(string userId);
    }
}
