using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Assignment4_0501.Data;
using Assignment4_0501.Models;

namespace Assignment4_0501.Controllers
{
    public class RoomsController : Controller
    {
        private readonly Dat154Assignment4Context _context;

        public RoomsController(Dat154Assignment4Context context)
        {
            _context = context;
        }

        // GET: Rooms
        public async Task<IActionResult> Index()
        {
            DateTime fromDateInput;
            DateTime toDateInput;

            if (TempData["fromDate"] == null || TempData["toDate"] == null)
            {
                fromDateInput = DateTime.Now;
                toDateInput = DateTime.Now;                                                                                                         
            } else
            {
                fromDateInput = (DateTime)TempData["fromDate"];
                toDateInput = (DateTime)TempData["toDate"];
            }

            TempData["fromDate"] = fromDateInput;
            TempData["toDate"] = toDateInput;

            // get both Rooms and Reservations from the
            // new model 'RoomReservation'
            RoomReservation model = new RoomReservation();
            model.Rooms = await _context.Rooms.ToListAsync();
            model.Reservations = await _context.Reservations.ToListAsync();

            return _context.Rooms != null ? 
                        View(model) :
                        Problem("Entity set 'Dat154Assignment4Context.Rooms'  is null.");
        }

        [HttpPost]
        public IActionResult SearchRoom(DateTime fromDate, DateTime toDate)
        {
            TempData["fromDate"] = fromDate;
            TempData["toDate"] = toDate;

            return RedirectToAction("Index", "Rooms");
        }

        public async Task<IActionResult> ConfirmBooking(int? id)
        {
            
            if (id == null || _context.Rooms == null)
            {
                return NotFound();
            }
            var room = await _context.Rooms.FindAsync(id);
            if (room == null)
            {
                return NotFound();
            }

            Reservation newReservation = new();
            int customerId = 123;
            int? roomNum = id;
            DateTime checkIn = (DateTime)TempData.Peek("fromDate");
            DateTime checkOut = (DateTime)TempData.Peek("toDate");

            newReservation.CustomerId = customerId;
            newReservation.RoomNum = (int)roomNum;
            newReservation.Checkin = checkIn;
            newReservation.Checkout = checkOut;

            _context.Add(newReservation);
            await _context.SaveChangesAsync();
            return View(room);
        }

        public async Task<IActionResult> BookRoom(int? id)
        {
            
            if (id == null || _context.Rooms == null)
            {
                return NotFound();
            }
            var room = await _context.Rooms.FindAsync(id);
            if (room == null)
            {
                return NotFound();
            }

            return View(room);
        }

        // GET: Rooms/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Rooms == null)
            {
                return NotFound();
            }

            var room = await _context.Rooms
                .FirstOrDefaultAsync(m => m.RoomNum == id);
            if (room == null)
            {
                return NotFound();
            }

            return View(room);
        }

        // GET: Rooms/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Rooms/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RoomNum,RoomStatus,NumBeds,RoomSize,ImageLink")] Room room)
        {
            if (ModelState.IsValid)
            {
                _context.Add(room);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(room);
        }

        // GET: Rooms/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Rooms == null)
            {
                return NotFound();
            }

            var room = await _context.Rooms.FindAsync(id);
            if (room == null)
            {
                return NotFound();
            }
            return View(room);
        }

        // POST: Rooms/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RoomNum,RoomStatus,NumBeds,RoomSize,ImageLink")] Room room)
        {
            if (id != room.RoomNum)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(room);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RoomExists(room.RoomNum))
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
            return View(room);
        }

        // GET: Rooms/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Rooms == null)
            {
                return NotFound();
            }

            var room = await _context.Rooms
                .FirstOrDefaultAsync(m => m.RoomNum == id);
            if (room == null)
            {
                return NotFound();
            }

            return View(room);
        }

        // POST: Rooms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Rooms == null)
            {
                return Problem("Entity set 'Dat154Assignment4Context.Rooms'  is null.");
            }
            var room = await _context.Rooms.FindAsync(id);
            if (room != null)
            {
                _context.Rooms.Remove(room);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RoomExists(int id)
        {
          return (_context.Rooms?.Any(e => e.RoomNum == id)).GetValueOrDefault();
        }
    }
}
