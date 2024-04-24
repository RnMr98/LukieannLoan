using LukieannLoanWeb.Contracts;
using LukieannLoanWeb.Data;

namespace LukieannLoanWeb.Repositories
{

    public class LoanTypeRepository : GenericRepository<LoanType>, ILoanTypeRepository
    {
        public LoanTypeRepository(ApplicationDbContext context) : base(context)
        {
        }

    }
}
