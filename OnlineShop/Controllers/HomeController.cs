using OnlineShop.Context;
using OnlineShop.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShop.Controllers
{
    public class HomeController : Controller
    {
        OnlineShopDBContext _context = new OnlineShopDBContext();

        public ActionResult Index()
        {
             var product=_context.Products.Where(i => i.isHome && i.IsApproved)
                .Select(i=>new ProductModel()
                { 
                    Id=i.Id,
                    Name = i.Name.Length > 50 ? i.Name.Substring(0, 47) + "..." : i.Name,
                    Description = i.Description.Length>50?i.Description.Substring(0,47)+"...":i.Description,
                    Price=i.Price,
                    Stock=i.Stock,
                    Image=i.Image,
                    CategoryId=i.CategoryId
                }).ToList();

            return View(product);
        }

        public ActionResult Details(int id)
        {

            return View(_context.Products.Where(i => i.Id == id).FirstOrDefault());
        }

        public ActionResult List(int? id)
        {

            var product = _context.Products
                .Where(i=>i.IsApproved)
                .Select(i => new ProductModel()
                {
                    Id = i.Id,
                    Name = i.Name.Length > 50 ? i.Name.Substring(0, 47) + "..." : i.Name,
                    Description = i.Description.Length > 50 ? i.Description.Substring(0, 47) + "..." : i.Description,
                    Price = i.Price,
                    Stock = i.Stock,
                    Image = i.Image ?? "1.jpg",
                    CategoryId = i.CategoryId
                }).AsQueryable();

            if (id != null)
            {
                product = product.Where(i => i.CategoryId == id);
            }

            return View(product.ToList());
        }

        public PartialViewResult GetCategories()
        {
            return PartialView(_context.Categories.ToList());
        }
    }
}