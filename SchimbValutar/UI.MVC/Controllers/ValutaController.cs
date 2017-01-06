using System;
using System.Linq;
using System.Threading.Tasks;
using Domain_Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UI.MVC.Data;

namespace UI.MVC.Controllers
{
    public class ValutaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ValutaController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Valuta
        public async Task<IActionResult> Index()
        {
            return View(await _context.Valuta.ToListAsync());
        }

        // GET: Valuta/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var valuta = await _context.Valuta.SingleOrDefaultAsync(m => m.Id == id);
            if (valuta == null)
            {
                return NotFound();
            }

            return View(valuta);
        }

        // GET: Valuta/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Valuta/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AcronimValuta,DenumireValuta,Multiplu,NumarCurentValuta,PozitieValuta,TipValuta")] Valuta valuta)
        {
            if (ModelState.IsValid)
            {
                valuta.Id = Guid.NewGuid().ToString();
                _context.Add(valuta);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(valuta);
        }

        // GET: Valuta/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var valuta = await _context.Valuta.SingleOrDefaultAsync(m => m.Id == id);
            if (valuta == null)
            {
                return NotFound();
            }
            return View(valuta);
        }

        // POST: Valuta/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,AcronimValuta,DenumireValuta,Multiplu,NumarCurentValuta,PozitieValuta,TipValuta")] Valuta valuta)
        {
            if (id != valuta.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(valuta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ValutaExists(valuta.Id))
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
            return View(valuta);
        }

        // GET: Valuta/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var valuta = await _context.Valuta.SingleOrDefaultAsync(m => m.Id == id);
            if (valuta == null)
            {
                return NotFound();
            }

            return View(valuta);
        }

        // POST: Valuta/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var valuta = await _context.Valuta.SingleOrDefaultAsync(m => m.Id == id);
            _context.Valuta.Remove(valuta);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool ValutaExists(string id)
        {
            return _context.Valuta.Any(e => e.Id == id);
        }
    }
}
