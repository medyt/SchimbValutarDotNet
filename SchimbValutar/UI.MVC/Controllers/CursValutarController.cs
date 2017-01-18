using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UI.MVC.Data;
using UI.MVC.Models;

namespace UI.MVC.Controllers
{
    public class CursValutarController : Controller
    {

        private readonly ApplicationDbContext _context;

        public CursValutarController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public IActionResult Index(CursValutarDto cursValutarDto, string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            if (!ModelState.IsValid) return BadRequest();
            _context.Add(new CursValutar
            {
                Id = Guid.NewGuid(),
                BuyingEuroToRon = cursValutarDto.BuyingEuroToRon,
                BuyingGbpToRon = cursValutarDto.BuyingGbpToRon,
                BuyingUsdToRon = cursValutarDto.BuyingUsdToRon,
                SellingEuroToRon = cursValutarDto.SellingEuroToRon,
                SellingGbpToRon = cursValutarDto.SellingGbpToRon,
                SellingUsdToRon = cursValutarDto.SellingUsdToRon
            });
            _context.SaveChanges();

            return View(returnUrl);
        }

    }
}