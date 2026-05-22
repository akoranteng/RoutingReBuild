using Microsoft.EntityFrameworkCore;
using RazorPagesRoutingDemo1.Models;
using System.Collections.Generic;

namespace RazorPagesRoutingDemo1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
