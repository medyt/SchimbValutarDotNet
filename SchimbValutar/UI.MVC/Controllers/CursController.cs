using System;
using System.Linq;
using System.Threading.Tasks;
using Domain_Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UI.MVC.Data;

namespace UI.MVC.Controllers
{
    public class CursController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CursController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Curs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Curs.ToListAsync());
        }

        // GET: Curs/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var curs = await _context.Curs.SingleOrDefaultAsync(m => m.Id == id);
            if (curs == null)
            {
                return NotFound();
            }

            return View(curs);
        }

        // GET: Curs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Curs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AcronimValuta,ActualizareValuta,CasierId,CursCumparare,CursOficialBnr,CursVanzare,DataCurs,DenumireValuta,Multiplu,NumarCurentValuta,NumarLista,ParitateEuro,PozitieValuta,SoldCurentValuta,TipValuta")] Curs curs)
        {
            if (ModelState.IsValid)
            {
                curs.Id = Guid.NewGuid().ToString();
                _context.Add(curs);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(curs);
        }

        // GET: Curs/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var curs = await _context.Curs.SingleOrDefaultAsync(m => m.Id == id);
            if (curs == null)
            {
                return NotFound();
            }
            return View(curs);
        }

        // POST: Curs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,AcronimValuta,ActualizareValuta,CasierId,CursCumparare,CursOficialBnr,CursVanzare,DataCurs,DenumireValuta,Multiplu,NumarCurentValuta,NumarLista,ParitateEuro,PozitieValuta,SoldCurentValuta,TipValuta")] Curs curs)
        {
            if (id != curs.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(curs);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CursExists(curs.Id))
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
            return View(curs);
        }

        // GET: Curs/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var curs = await _context.Curs.SingleOrDefaultAsync(m => m.Id == id);
            if (curs == null)
            {
                return NotFound();
            }

            return View(curs);
        }

        // POST: Curs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var curs = await _context.Curs.SingleOrDefaultAsync(m => m.Id == id);
            _context.Curs.Remove(curs);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool CursExists(string id)
        {
            return _context.Curs.Any(e => e.Id == id);
        }
    }
}
