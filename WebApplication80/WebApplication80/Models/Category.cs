using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication80.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }


        public ICollection<Product> Products { get; set; }
    }
}