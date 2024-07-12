using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication80.Models;

namespace WebApplication80.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("conStr")
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}