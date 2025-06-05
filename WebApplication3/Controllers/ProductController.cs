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

        
        public IActionResult Create()
        {
            return View();
        }

        
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                context.Products.Add(product);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(product);
        }


        public IActionResult Details(int id)
        {
            var products = context.Products.Find(id);
            return View(products);
        }
    }
}
