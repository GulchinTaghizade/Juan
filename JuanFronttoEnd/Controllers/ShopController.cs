using JuanFronttoEnd.DAL;
using JuanFronttoEnd.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JuanFronttoEnd.Controllers
{
    public class ShopController : Controller
    {
        private AppDbContext _context { get; }
        public ShopController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ShopViewModel shop = new ShopViewModel
            {
                Products = _context.Products.Where(p => !p.IsDeleted).Include(p => p.Images).ToList(),
                ProductImages = _context.ProductImages.ToList(),
                Categories=_context.Categories.ToList()
            };
            return View(shop);
        }
    }
}
