using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OnlineShop.Context
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<OnlineShopDBContext>
    {
        protected override void Seed(OnlineShopDBContext context)
        {

            var categories = new List<Category>()
            {
                new Category(){Name="Camera",Description="Camera products"},
                new Category(){Name="Laptop",Description="Laptop products" },
                new Category(){Name="Phone",Description="Phone products" },
                new Category(){Name="white goods",Description="white goods products" },
                new Category(){Name="Electronics",Description="Electronics products" }
            };

            foreach (var category in categories)
            {
                context.Categories.Add(category);

            }
            context.SaveChanges();

            var products = new List<Product>()
            {
                new Product(){Name="Canon Camera EOS",Description="Mirrorless camera CANON EOS RP+RF24-105mm IS STM 26.2 MPx, WI-FI",Price=2000,Stock=500 ,IsApproved=true,CategoryId=1,isHome=true,Image="1.jpg"},
                new Product(){Name="Canon Camera",Description="Mirrorless camera CANON EOS RP BODY 26.2 MPx, WI-FI",Price=3000,Stock=500,IsApproved=true,CategoryId=1,isHome=true,Image="2.jpg"},
                new Product(){Name="Canon Camera",Description="Mirrorless camera CANON EOS RP BODY 26.2 MPx, WI-FI",Price=4000,Stock=500,IsApproved=true,CategoryId=1,isHome=true,Image="3.jpg"},
                new Product(){Name="Canon Camera",Description="Mirrorless camera CANON EOS RP BODY 26.2 MPx, WI-FI",Price=5000,Stock=500,IsApproved=true,CategoryId=1,isHome=true,Image="4.jpg"},

                new Product(){Name="SAMSUNG GALAXY S22",Description="Новият Samsung Galaxy S22 е с тънка симетрична рамка и монохромен корпус на камерата, който изразява една красива линейна система от камери.",Price=2000,Stock=600,IsApproved=true,CategoryId=3,isHome=true,Image="5.jpg"},
                new Product(){Name="SAMSUNG GALAXY S21",Description="Новият Samsung Galaxy S22 е с тънка симетрична рамка и монохромен корпус на камерата, който изразява една красива линейна система от камери.Mirrorless camera CANON EOS RP BODY 26.2 MPx, WI-FI",Price=3000,Stock=500,IsApproved=true,CategoryId=3,isHome=true,Image="6.jpg"},
                new Product(){Name="SAMSUNG GALAXY A52",Description="Новият Samsung Galaxy S22 е с тънка симетрична рамка и монохромен корпус на камерата, който изразява една красива линейна система от камери.",Price=3000,Stock=500,IsApproved=true,CategoryId=3,isHome=true,Image="7.jpg"},
                new Product(){Name="SAMSUNG GALAXY A32",Description="Новият Samsung Galaxy S22 е с тънка симетрична рамка и монохромен корпус на камерата, който изразява една красива линейна система от камери.",Price=3000,Stock=500,IsApproved=true,CategoryId=3,isHome=true,Image="8.png"},


                new Product(){Name="Нетбук UltraSlim LENOVO IdeaPad 1 ",Description="Новият Samsung Galaxy S22 е с тънка симетрична рамка и монохромен корпус на камерата, който изразява една красива линейна система от камери.",Price=3000,Stock=500,IsApproved=true,CategoryId=2,isHome=true,Image="9.jpg"},
                new Product(){Name="Лаптоп LENOVO UltraSlim IdeaPad 3 ",Description="Новият Samsung Galaxy S22 е с тънка симетрична рамка и монохромен корпус на камерата, който изразява една красива линейна система от камери.",Price=3000,Stock=500,IsApproved=true,CategoryId=2,isHome=true,Image="10.jpg"},
                new Product(){Name="Лаптоп ASUS E510MA-EJ594",Description="Новият Samsung Galaxy S22 е с тънка симетрична рамка и монохромен корпус на камерата, който изразява една красива линейна система от камери.",Price=3000,Stock=500,IsApproved=true,CategoryId=2,isHome=true,Image="11.jpg"},
                new Product(){Name="Лаптоп LENOVO UltraSlim IdeaPad 4",Description="Новият Samsung Galaxy S22 е с тънка симетрична рамка и монохромен корпус на камерата, който изразява една красива линейна система от камери.",Price=3000,Stock=500,IsApproved=true,CategoryId=2,isHome=true,Image="12.jpg"}

            };

            foreach (var product in products)
            {
                context.Products.Add(product);
            }

            base.Seed(context);
        }
    }
}