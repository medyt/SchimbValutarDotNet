using System;
using System.Linq;
using System.Threading.Tasks;
using Domain_Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UI.MVC.Data;

namespace UI.MVC.Controllers
{
    public class OperatieController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OperatieController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Operatie
        public async Task<IActionResult> Index()
        {
            return View(await _context.Operatie.ToListAsync());
        }

        // GET: Operatie/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var operatie = await _context.Operatie.SingleOrDefaultAsync(m => m.Id == id);
            if (operatie == null)
            {
                return NotFound();
            }

            return View(operatie);
        }

        // GET: Operatie/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Operatie/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AcronimValuta,AdaosRealizat,AdaosRelativ,CalitateClient,CodTaraClient,CursOficialBnr,CursValutarStabilit,DataOperatiune,DenumireTaraClient,InstrumentPlata,Multiplu,NumarCurentChitanta,NumarDocument,NumarDocumentIdentitate,NumarLista,NumarRaportZ,NumePrenumeClient,ParitateEuro,ProcentComisionCard,ProcentComisionCec,SerieChitanta,SerieDocumentIdentitate,SoldPrecedent,StareOperatiuneTranzactie,SumaValuta,TipDocumentIdentitate,ValoareComision,ValoareLei,ValoareSpeze")] Operatie operatie)
        {
            if (ModelState.IsValid)
            {
                operatie.Id = Guid.NewGuid().ToString();
                _context.Add(operatie);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(operatie);
        }

        // GET: Operatie/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var operatie = await _context.Operatie.SingleOrDefaultAsync(m => m.Id == id);
            if (operatie == null)
            {
                return NotFound();
            }
            return View(operatie);
        }

        // POST: Operatie/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,AcronimValuta,AdaosRealizat,AdaosRelativ,CalitateClient,CodTaraClient,CursOficialBnr,CursValutarStabilit,DataOperatiune,DenumireTaraClient,InstrumentPlata,Multiplu,NumarCurentChitanta,NumarDocument,NumarDocumentIdentitate,NumarLista,NumarRaportZ,NumePrenumeClient,ParitateEuro,ProcentComisionCard,ProcentComisionCec,SerieChitanta,SerieDocumentIdentitate,SoldPrecedent,StareOperatiuneTranzactie,SumaValuta,TipDocumentIdentitate,ValoareComision,ValoareLei,ValoareSpeze")] Operatie operatie)
        {
            if (id != operatie.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(operatie);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OperatieExists(operatie.Id))
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
            return View(operatie);
        }

        // GET: Operatie/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var operatie = await _context.Operatie.SingleOrDefaultAsync(m => m.Id == id);
            if (operatie == null)
            {
                return NotFound();
            }

            return View(operatie);
        }

        // POST: Operatie/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var operatie = await _context.Operatie.SingleOrDefaultAsync(m => m.Id == id);
            _context.Operatie.Remove(operatie);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool OperatieExists(string id)
        {
            return _context.Operatie.Any(e => e.Id == id);
        }
    }
}
