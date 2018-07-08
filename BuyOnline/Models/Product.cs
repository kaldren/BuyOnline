using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuyOnline.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        public short CategoryId { get; set; }
        public Category Category { get; set; }

        public string AuthorId { get; set; }
        public ApplicationUser Author { get; set; }
    }
}