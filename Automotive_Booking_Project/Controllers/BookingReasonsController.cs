using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Automotive_Booking_Project.Data;
using Automotive_Booking_Project.Models;

namespace Automotive_Booking_Project.Controllers
{
    public class BookingReasonsController : Controller
    {
        private readonly Automotive_Booking_ProjectContext _context;

        public BookingReasonsController(Automotive_Booking_ProjectContext context)
        {
            _context = context;
        }

        // GET: BookingReasons
        public async Task<IActionResult> Index()
        {
            return View(await _context.BookingReason.ToListAsync());
        }

        // GET: BookingReasons/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookingReason = await _context.BookingReason
                .FirstOrDefaultAsync(m => m.BookingReason_Id == id);
            if (bookingReason == null)
            {
                return NotFound();
            }

            return View(bookingReason);
        }

        // GET: BookingReasons/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BookingReasons/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BookingReason_Id,reason")] BookingReason bookingReason)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bookingReason);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bookingReason);
        }

        // GET: BookingReasons/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookingReason = await _context.BookingReason.FindAsync(id);
            if (bookingReason == null)
            {
                return NotFound();
            }
            return View(bookingReason);
        }

        // POST: BookingReasons/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BookingReason_Id,reason")] BookingReason bookingReason)
        {
            if (id != bookingReason.BookingReason_Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bookingReason);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookingReasonExists(bookingReason.BookingReason_Id))
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
            return View(bookingReason);
        }

        // GET: BookingReasons/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookingReason = await _context.BookingReason
                .FirstOrDefaultAsync(m => m.BookingReason_Id == id);
            if (bookingReason == null)
            {
                return NotFound();
            }

            return View(bookingReason);
        }

        // POST: BookingReasons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bookingReason = await _context.BookingReason.FindAsync(id);
            _context.BookingReason.Remove(bookingReason);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookingReasonExists(int id)
        {
            return _context.BookingReason.Any(e => e.BookingReason_Id == id);
        }
    }
}
