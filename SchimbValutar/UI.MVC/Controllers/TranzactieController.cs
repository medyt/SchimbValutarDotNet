using System;
using Microsoft.AspNetCore.Mvc;
using UI.MVC.Data;
using UI.MVC.Models;

namespace UI.MVC.Controllers
{
    public class TranzactieController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TranzactieController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(TranzactieDto tranzactieDto)
        {
            if (!ModelState.IsValid) return BadRequest();

            _context.Add(new Tranzactie
            {
                Id = Guid.NewGuid(),
                TipOperatie = tranzactieDto.TipOperatie,
                Din = tranzactieDto.Din,
                In = tranzactieDto.In,
                SumaTranzationata = tranzactieDto.SumaTranzationata,
                SumaDatorata = tranzactieDto.SumaDatorata,
                ActIdentitate = tranzactieDto.ActIdentitate,
                Seria = tranzactieDto.Seria,
                Numarul = tranzactieDto.Numarul,
                Cnp = tranzactieDto.Cnp,
                IsDeleted = false
            });
            _context.SaveChanges();

            return View();
        }
    }
}