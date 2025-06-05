using System;
using Azure.Core;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext context;

        public ProductController(ApplicationDbContext _context)
        {
            context = _context;
        }


        public IActionResult Index()
        {
            var products = context.Products.ToList();
            return View(products);
        }

        
        public IActionResult Create(Product request)
        {
            if (ModelState.IsValid)
            {
                context.Products.Add(request);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Create", request);
        }


        public IActionResult Details(int id)
        {
            var products = context.Products.Find(id);
            return View(products);
        }
    }
}
