using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LukieannLoanWeb.Data;
using LukieannLoanWeb.Contracts;
using AutoMapper;
using LukieannLoanWeb.Models;

namespace LukieannLoanWeb.Controllers
{
    public class LoanTypesController : Controller
    {
        private readonly ILoanTypeRepository loanTypeRepository;
        private readonly IMapper mapper;

        public LoanTypesController(ILoanTypeRepository loanTypeRepository, IMapper mapper)
        {
            this.loanTypeRepository = loanTypeRepository;
            this.mapper = mapper;
        }

        // GET: LoanTypes
        public async Task<IActionResult> Index()
        {
            var loanTypes = mapper.Map<List<LoanTypeVM>>(await loanTypeRepository.GetAllAsync());
            return View(loanTypes);
        }

        // GET: LoanTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            var loanType = await loanTypeRepository.GetAsync(id);
            if (loanType == null)
            {
                return NotFound();
            }

            var loanTypeVM = mapper.Map<LoanTypeVM>(loanType);
            return View(loanTypeVM);
        }

        // GET: LoanTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LoanTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(LoanTypeVM loanTypeVM)
        {
            if (ModelState.IsValid)
            {
                var loanType = mapper.Map<LoanType>(loanTypeVM);
                await loanTypeRepository.AddAsync(loanType);
                return RedirectToAction(nameof(Index));
            }
            return View(loanTypeVM);
        }

        // GET: LoanTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            var loanType = await loanTypeRepository.GetAsync(id);
            if (loanType == null)
            {
                return NotFound();
            }

            var loanTypeVM = mapper.Map<LoanTypeVM>(loanType);
            return View(loanTypeVM);
        }

        // POST: LoanTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,LoanTypeVM loanTypeVM)
        {
            if (id != loanTypeVM.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var loanTypes = mapper.Map<LoanType>(loanTypeVM);
                        await loanTypeRepository.UpdateAsync(loanTypes);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await loanTypeRepository.Exists(loanTypeVM.Id))
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
            return View(loanTypeVM);
        }

        // POST: LoanTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await loanTypeRepository.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
