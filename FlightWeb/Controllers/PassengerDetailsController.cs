using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FlightHandling;
using FlightWeb.Data;

namespace FlightWeb.Controllers
{
    public class PassengerDetailsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PassengerDetailsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PassengerDetails
        public async Task<IActionResult> Index()
        {
            return View(await _context.Passengers.ToListAsync());
        }

        // GET: PassengerDetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var passengerDetails = await _context.Passengers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (passengerDetails == null)
            {
                return NotFound();
            }

            return View(passengerDetails);
        }

        // GET: PassengerDetails/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PassengerDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Weight")] PassengerDetails passengerDetails)
        {
            if (ModelState.IsValid)
            {
                _context.Add(passengerDetails);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(passengerDetails);
        }

        // GET: PassengerDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var passengerDetails = await _context.Passengers.FindAsync(id);
            if (passengerDetails == null)
            {
                return NotFound();
            }
            return View(passengerDetails);
        }

        // POST: PassengerDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Weight")] PassengerDetails passengerDetails)
        {
            if (id != passengerDetails.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(passengerDetails);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PassengerDetailsExists(passengerDetails.Id))
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
            return View(passengerDetails);
        }

        // GET: PassengerDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var passengerDetails = await _context.Passengers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (passengerDetails == null)
            {
                return NotFound();
            }

            return View(passengerDetails);
        }

        // POST: PassengerDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var passengerDetails = await _context.Passengers.FindAsync(id);
            if (passengerDetails != null)
            {
                _context.Passengers.Remove(passengerDetails);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PassengerDetailsExists(int id)
        {
            return _context.Passengers.Any(e => e.Id == id);
        }
    }
}
