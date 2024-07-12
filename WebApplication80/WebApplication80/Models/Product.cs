﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication80.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}