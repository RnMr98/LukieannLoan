using AutoMapper;
using LukieannLoanWeb.Contracts;
using LukieannLoanWeb.Data;
using LukieannLoanWeb.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace LukieannLoanWeb.Repositories
{
    public class LoanRequestRepository : GenericRepository<LoanRequest>, ILoanRequestRepository
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly UserManager<User> userManager;

        public LoanRequestRepository(ApplicationDbContext context, 
            IMapper mapper, 
            IHttpContextAccessor httpContextAccessor, 
            UserManager<User> userManager) : base(context)
        {
            this.context = context;
            this.mapper = mapper;
            this.httpContextAccessor = httpContextAccessor;
            this.userManager = userManager;
        }

        public async Task CreateLoanRequest(LoanRequestCreateVM model)
        {
            var user = await userManager.GetUserAsync(httpContextAccessor?.HttpContext?.User);

            var loanRequest = mapper.Map<LoanRequest>(model);
            loanRequest.Date= DateTime.Now;
            loanRequest.UserId = user.Id;

            await AddAsync(loanRequest);

        }

        public async Task<List<LoanRequest>> GetAllAsync(string userId)
        {
            var view = await context.LoanRequests.Include(q => q.LoanType).Include(q => q.LoanTerm)
                .Where(q => q.UserId == userId).ToListAsync();
            return (view);
        }

        public async Task<LoanViewVM> GetMyLoanDetails()
        {
            var user = await userManager.GetUserAsync(httpContextAccessor?.HttpContext?.User);
            var loanRequests = mapper.Map<List<LoanRequestVM>>( await GetAllAsync(user.Id));
            
            

            var model = new LoanViewVM(loanRequests);
            return model;
        }
    }
}
