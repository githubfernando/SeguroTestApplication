using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplicationSeguros.Data;
using WebApplicationSeguros.Models;

namespace WebApplicationSeguros
{
    public class InsurancePolicyController : Controller
    {
        private readonly DBContextInsurances _context;

        public InsurancePolicyController(DBContextInsurances context)
        {
            _context = context;
        }

        // GET: InsurancePolicies
        public async Task<IActionResult> Index()
        {
            return View(await _context.InsurancePolicies.ToListAsync());
        }

        // GET: InsurancePolicies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insurancePolicy = await _context.InsurancePolicies
                .FirstOrDefaultAsync(m => m.id == id);
            if (insurancePolicy == null)
            {
                return NotFound();
            }

            return View(insurancePolicy);
        }

        // GET: InsurancePolicies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: InsurancePolicies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,IdentificationNumber,Name,Description,NameCoverType,CoverPercent,StartDatePoliceValidity,CoveragePeriod,PolicyPrice,NameTypeRisk,Active")] InsurancePolicy insurancePolicy)
        {
            if (ModelState.IsValid)
            {
                _context.Add(insurancePolicy);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(insurancePolicy);
        }

        // GET: InsurancePolicies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insurancePolicy = await _context.InsurancePolicies.FindAsync(id);
            if (insurancePolicy == null)
            {
                return NotFound();
            }
            return View(insurancePolicy);
        }

        // POST: InsurancePolicies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,IdentificationNumber,Name,Description,NameCoverType,CoverPercent,StartDatePoliceValidity,CoveragePeriod,PolicyPrice,NameTypeRisk,Active")] InsurancePolicy insurancePolicy)
        {
            if (id != insurancePolicy.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(insurancePolicy);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InsurancePolicyExists(insurancePolicy.id))
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
            return View(insurancePolicy);
        }

        // GET: InsurancePolicies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insurancePolicy = await _context.InsurancePolicies
                .FirstOrDefaultAsync(m => m.id == id);
            if (insurancePolicy == null)
            {
                return NotFound();
            }

            return View(insurancePolicy);
        }

        // POST: InsurancePolicies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var insurancePolicy = await _context.InsurancePolicies.FindAsync(id);
            _context.InsurancePolicies.Remove(insurancePolicy);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InsurancePolicyExists(int id)
        {
            return _context.InsurancePolicies.Any(e => e.id == id);
        }
    }
}
