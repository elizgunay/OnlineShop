using Microsoft.AspNet.Identity.EntityFramework;
using OnlineShop.Identity;
using OnlineShop.Models;
using OnlineShop.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OnlineShop.Context
{
    public class OnlineShopDBContext:DbContext
    {
        public OnlineShopDBContext() : base("dataConnection")
        {
           // Database.SetInitializer(new DataInitializer());
            //Database.SetInitializer(new IdentityInitializer());

        }

       
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }

           
        }
    }
