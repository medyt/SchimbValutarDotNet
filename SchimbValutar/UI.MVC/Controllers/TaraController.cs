using System;
using System.Linq;
using System.Threading.Tasks;
using Domain_Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UI.MVC.Data;

namespace UI.MVC.Controllers
{
    public class TaraController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TaraController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Tara
        public async Task<IActionResult> Index()
        {
            return View(await _context.Tara.ToListAsync());
        }

        // GET: Tara/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tara = await _context.Tara.SingleOrDefaultAsync(m => m.Id == id);
            if (tara == null)
            {
                return NotFound();
            }

            return View(tara);
        }

        // GET: Tara/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tara/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Cod,Denumire,TotalCumparariEuro,TotalVanzariEuro")] Tara tara)
        {
            if (ModelState.IsValid)
            {
                tara.Id = Guid.NewGuid().ToString();
                _context.Add(tara);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(tara);
        }

        // GET: Tara/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tara = await _context.Tara.SingleOrDefaultAsync(m => m.Id == id);
            if (tara == null)
            {
                return NotFound();
            }
            return View(tara);
        }

        // POST: Tara/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,Cod,Denumire,TotalCumparariEuro,TotalVanzariEuro")] Tara tara)
        {
            if (id != tara.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tara);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TaraExists(tara.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(tara);
        }

        // GET: Tara/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tara = await _context.Tara.SingleOrDefaultAsync(m => m.Id == id);
            if (tara == null)
            {
                return NotFound();
            }

            return View(tara);
        }

        // POST: Tara/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var tara = await _context.Tara.SingleOrDefaultAsync(m => m.Id == id);
            _context.Tara.Remove(tara);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool TaraExists(string id)
        {
            return _context.Tara.Any(e => e.Id == id);
        }
    }
}
