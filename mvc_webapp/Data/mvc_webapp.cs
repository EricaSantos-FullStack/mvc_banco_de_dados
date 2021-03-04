using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using mvc_webapp.Models;

namespace mvc_webapp.Data
{
    public class mvc_webappDbContext : DbContext
    {
        public mvc_webappDbContext(DbContextOptions<mvc_webappDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Produtos { get; set; }
    }
}