using System;
using System.Linq;
using System.Threading.Tasks;
using Domain_Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UI.MVC.Data;

namespace UI.MVC.Controllers
{
    public class CasierController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CasierController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Casier
        public async Task<IActionResult> Index()
        {
            return View(await _context.Casier.ToListAsync());
        }

        // GET: Casier/Details/5
        public async Task<IActionResult> Details(Guid id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var casier = await _context.Casier.SingleOrDefaultAsync(m => m.Id == id);
            if (casier == null)
            {
                return NotFound();
            }

            return View(casier);
        }

        // GET: Casier/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Casier/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AccesCasaLeiValuta,AccesOperatiiTransfer,AccesRaportAdaosLunar,AccesRaportBnrNou,AccesRaportBnrVechi,AccesRaportSpecial,AccesRaportTransferuriZilnice,AccesRaportTranzactiiZilnice,AccesTransferuriLunare,AccesTranzactiiLunare,Nume,Prenume")] Casier casier)
        {
            if (ModelState.IsValid)
            {
                casier.Id = Guid.NewGuid();
                _context.Add(casier);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(casier);
        }

        // GET: Casier/Edit/5
        public async Task<IActionResult> Edit(Guid id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var casier = await _context.Casier.SingleOrDefaultAsync(m => m.Id == id);
            if (casier == null)
            {
                return NotFound();
            }
            return View(casier);
        }

        // POST: Casier/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,AccesCasaLeiValuta,AccesOperatiiTransfer,AccesRaportAdaosLunar,AccesRaportBnrNou,AccesRaportBnrVechi,AccesRaportSpecial,AccesRaportTransferuriZilnice,AccesRaportTranzactiiZilnice,AccesTransferuriLunare,AccesTranzactiiLunare,Nume,Prenume")] Casier casier)
        {
            if (id != casier.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(casier);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CasierExists(casier.Id))
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
            return View(casier);
        }

        // GET: Casier/Delete/5
        public async Task<IActionResult> Delete(Guid id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var casier = await _context.Casier.SingleOrDefaultAsync(m => m.Id == id);
            if (casier == null)
            {
                return NotFound();
            }

            return View(casier);
        }

        // POST: Casier/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var casier = await _context.Casier.SingleOrDefaultAsync(m => m.Id == id);
            _context.Casier.Remove(casier);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool CasierExists(Guid id)
        {
            return _context.Casier.Any(e => e.Id == id);
        }
    }
}
