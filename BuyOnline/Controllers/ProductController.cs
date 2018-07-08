﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BuyOnline.Models;
using BuyOnline.ViewModels;

namespace BuyOnline.Controllers
{
    public class ProductController : Controller
    {
        private ApplicationDbContext _context;

        public ProductController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Product
        public ActionResult Create()
        {
            var viewModel = new ProductFormViewModel
            {
                Categories = _context.Categories.ToList()
            };

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Create(ProductFormViewModel viewModel)
        {
            var category = _context
                .Categories
                .SingleOrDefault(c => c.Id == viewModel.Category);

            var product = new Product
            {
                Name = viewModel.Name,
                Price = viewModel.Price,
                Description = viewModel.Description,
                Category = category
            };

            _context.Products.Add(product);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}