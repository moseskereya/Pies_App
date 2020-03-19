using System;
using System.Collections.Generic;
using System.Text;
using Pie.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Pie.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCart> shoppingCarts{ get; set; }

    }
}
