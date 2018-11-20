using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Chen_Xuxian_HW6.Models;
using Microsoft.EntityFrameworkCore;

namespace Chen_Xuxian_HW6.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        //You need one db set for each model class. For example:
        public DbSet<Supplier> Suppliers{ get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<SupplyOrder> SupplyOrders { get; set; }
    }
} 