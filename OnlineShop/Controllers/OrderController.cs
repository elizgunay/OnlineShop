using OnlineShop.Context;
using OnlineShop.Models;
using OnlineShop.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShop.Controllers
{
    [Authorize(Roles = "admin")]
    public class OrderController : Controller
    {
        OnlineShopDBContext db = new OnlineShopDBContext();

        // GET: Order
        public ActionResult Index()
        {
            var orders = db.Orders.Select(i => new AdminOrderModel()
            {
                Id = i.Id,
                OrderNumber = i.OrderNumber,
                OrderDate = i.OrderDate,
                OrderState = i.OrderState,
                Total = i.Total,
                Count=i.OrderLines.Count
            }).ToList();

            return View(orders);
        }

        public ActionResult Details(int id)
        {
            var entity = db.Orders.Where(i => i.Id == id)
                .Select(i => new OrderDetailsModel()
                {
                    OrderId = i.Id,
                    Username=i.Username,
                    OrderNumber = i.OrderNumber,
                    Total = i.Total,
                    OrderDate = i.OrderDate,
                    OrderState = i.OrderState,
                    Address = i.Address,
                    Adres1 = i.Adres1,
                    City = i.City,
                    Semt = i.Semt,
                    Mahale = i.Mahale,
                    Code = i.Code,
                    OrderLines = i.OrderLines.Select(a => new OrderLineModel()
                    {
                        ProductId = a.ProductId,
                        ProductName = a.Product.Name.Length > 50 ? a.Product.Name.Substring(0, 47) + "..." : a.Product.Name,
                        Image = a.Product.Image,
                        Quantity = a.Quantity,
                        Price = a.Price
                    }).ToList()
                }).FirstOrDefault();

            return View(entity);
        }

        public ActionResult UpdateOrderState(int OrderId,EnumOrderState OrderState)
        {
            var order = db.Orders.FirstOrDefault(i => i.Id == OrderId);

            if(order != null)
            {
                order.OrderState = OrderState;
                db.SaveChanges();

                TempData["message"] = "Your information has been saved!";

                return RedirectToAction("Details", new { id = OrderId });
            }

            return RedirectToAction("Index");
        }
    }
}