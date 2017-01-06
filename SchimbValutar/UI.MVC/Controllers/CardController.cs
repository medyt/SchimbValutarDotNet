using System;
using System.Linq;
using System.Threading.Tasks;
using Domain_Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UI.MVC.Data;

namespace UI.MVC.Controllers
{
    public class CardController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CardController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Card
        public async Task<IActionResult> Index()
        {
            return View(await _context.Card.ToListAsync());
        }

        // GET: Card/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var card = await _context.Card.SingleOrDefaultAsync(m => m.Id == id);
            if (card == null)
            {
                return NotFound();
            }

            return View(card);
        }

        // GET: Card/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Card/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ClientId,CursValutarStabilit,DataTranzactie,DenumireCard,NumarBonFiscal,NumarCard,NumarChitantaSchimbValutar,SerieChitantaSchimbValutar,SumaTranzactionata,ValoareLei,Valuta")] Card card)
        {
            if (ModelState.IsValid)
            {
                card.Id = Guid.NewGuid().ToString();
                _context.Add(card);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(card);
        }

        // GET: Card/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var card = await _context.Card.SingleOrDefaultAsync(m => m.Id == id);
            if (card == null)
            {
                return NotFound();
            }
            return View(card);
        }

        // POST: Card/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,ClientId,CursValutarStabilit,DataTranzactie,DenumireCard,NumarBonFiscal,NumarCard,NumarChitantaSchimbValutar,SerieChitantaSchimbValutar,SumaTranzactionata,ValoareLei,Valuta")] Card card)
        {
            if (id != card.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(card);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CardExists(card.Id))
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
            return View(card);
        }

        // GET: Card/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var card = await _context.Card.SingleOrDefaultAsync(m => m.Id == id);
            if (card == null)
            {
                return NotFound();
            }

            return View(card);
        }

        // POST: Card/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var card = await _context.Card.SingleOrDefaultAsync(m => m.Id == id);
            _context.Card.Remove(card);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool CardExists(string id)
        {
            return _context.Card.Any(e => e.Id == id);
        }
    }
}
