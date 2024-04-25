using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LukieannLoanWeb.Data;
using LukieannLoanWeb.Models;
using AutoMapper;
using LukieannLoanWeb.Contracts;
using Microsoft.AspNetCore.Authorization;

namespace LukieannLoanWeb.Controllers
{
    [Authorize]
    public class LoanRequestsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILoanRequestRepository loanRequestRepository;

        public LoanRequestsController(ApplicationDbContext context, ILoanRequestRepository loanRequestRepository)
        {
            _context = context;
            this.loanRequestRepository = loanRequestRepository;
        }

        // GET: LoanRequests
        public async Task<IActionResult> Index()
        {
            return View(await loanRequestRepository.GetAllAsync());
        }

        // GET: LoanRequests/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loanRequest = await _context.LoanRequests
                .Include(l => l.LoanTerm)
                .Include(l => l.LoanType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (loanRequest == null)
            {
                return NotFound();
            }

            return View(loanRequest);
        }

        public async Task<ActionResult> MyLoans()
        {
            var model = await loanRequestRepository.GetMyLoanDetails();
            
            return View(model);
        }

        // GET: LoanRequests/Create
        public IActionResult Create()
        {
            var model = new LoanRequestCreateVM
            {
                Date = DateTime.Now,
                LoanTerms = new SelectList(_context.LoanTerms, "Id", "Term"),
                LoanTypes = new SelectList(_context.LoanTypes, "Id", "Name")
            };
            return View(model);
        }

        // POST: LoanRequests/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(LoanRequestCreateVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await loanRequestRepository.CreateLoanRequest(model);
                    return RedirectToAction(nameof(MyLoans));
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, "An Error Has Occurred. Please Try Again Later");
            }

            model.LoanTerms = new SelectList(_context.LoanTerms, "Id", "Term", model.LoanTermId);
            model.LoanTypes = new SelectList(_context.LoanTypes, "Id", "Name", model.LoanTypeId);
            model.Date = DateTime.Now;
            return View(model);
        }

        // GET: LoanRequests/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loanRequest = await _context.LoanRequests.FindAsync(id);
            if (loanRequest == null)
            {
                return NotFound();
            }
            ViewData["LoanTermID"] = new SelectList(_context.LoanTerms, "Id", "Term", loanRequest.LoanTermID);
            ViewData["LoanTypeId"] = new SelectList(_context.LoanTypes, "Id", "Name", loanRequest.LoanTypeId);
            return View(loanRequest);
        }

        // POST: LoanRequests/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Date,UserId,LoanTypeId,LoanTermID,Amount")] LoanRequest loanRequest)
        {
            if (id != loanRequest.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(loanRequest);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LoanRequestExists(loanRequest.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["LoanTermID"] = new SelectList(_context.LoanTerms, "Id", "Term", loanRequest.LoanTermID);
            ViewData["LoanTypeId"] = new SelectList(_context.LoanTypes, "Id", "Id", loanRequest.LoanTypeId);
            return View(loanRequest);
        }

        // GET: LoanRequests/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loanRequest = await _context.LoanRequests
                .Include(l => l.LoanTerm)
                .Include(l => l.LoanType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (loanRequest == null)
            {
                return NotFound();
            }

            return View(loanRequest);
        }

        // POST: LoanRequests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var loanRequest = await _context.LoanRequests.FindAsync(id);
            if (loanRequest != null)
            {
                _context.LoanRequests.Remove(loanRequest);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LoanRequestExists(int id)
        {
            return _context.LoanRequests.Any(e => e.Id == id);
        }
    }
}
