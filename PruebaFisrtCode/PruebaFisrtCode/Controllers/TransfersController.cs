using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PruebaFisrtCode.Data;
using PruebaFisrtCode.Models;

namespace PruebaFisrtCode.Controllers
{
    public class TransfersController : Controller
    {
        private readonly BankContext _context;

        public TransfersController(BankContext context)
        {
            _context = context;
        }

        // GET: Transfers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Transfers.ToListAsync());
        }

        // GET: Transfers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transfers = await _context.Transfers
                .FirstOrDefaultAsync(m => m.TransferID == id);
            if (transfers == null)
            {
                return NotFound();
            }

            return View(transfers);
        }

        // GET: Transfers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Transfers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TransferID,ClientsID,Amount,Description,Date")] Transfers transfers)
        {
            if (ModelState.IsValid)
            {
                _context.Add(transfers);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(transfers);
        }

        // GET: Transfers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transfers = await _context.Transfers.FindAsync(id);
            if (transfers == null)
            {
                return NotFound();
            }
            return View(transfers);
        }

        // POST: Transfers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TransferID,ClientsID,Amount,Description,Date")] Transfers transfers)
        {
            if (id != transfers.TransferID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(transfers);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TransfersExists(transfers.TransferID))
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
            return View(transfers);
        }

        // GET: Transfers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transfers = await _context.Transfers
                .FirstOrDefaultAsync(m => m.TransferID == id);
            if (transfers == null)
            {
                return NotFound();
            }

            return View(transfers);
        }

        // POST: Transfers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var transfers = await _context.Transfers.FindAsync(id);
            _context.Transfers.Remove(transfers);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TransfersExists(int id)
        {
            return _context.Transfers.Any(e => e.TransferID == id);
        }
    }
}
