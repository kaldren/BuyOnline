﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BuyOnline.Models;

namespace BuyOnline.ViewModels
{
    public class ProductFormViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string CategoryName { get; set; }
        public short Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}