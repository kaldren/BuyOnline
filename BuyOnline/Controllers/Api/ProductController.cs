using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BuyOnline.Models;
using BuyOnline.ViewModels;

namespace BuyOnline.Controllers.Api
{
    public class ProductController : ApiController
    {
        private readonly ApplicationDbContext _context;

        public ProductController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult Update(int id, ProductFormViewModel viewModel)
        {
            var product = _context.Products.SingleOrDefault(p => p.Id == id);
            var category = _context.Categories.SingleOrDefault(p => p.Id == viewModel.Category);

            product.Name = viewModel.Name;
            product.Price = viewModel.Price;
            product.Description = viewModel.Description;
            product.Category = category;

            _context.SaveChanges();

            return Ok();
        }
    }
}
