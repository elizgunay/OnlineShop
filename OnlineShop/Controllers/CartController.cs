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
    public class CartController : Controller
    {
        private OnlineShopDBContext db = new OnlineShopDBContext();

        // GET: Cart
        public ActionResult Index()
        {
            return View(GetCart());
        }

        public ActionResult AddToCart(int Id)
        {
            var product = db.Products.FirstOrDefault(i => i.Id == Id);

            if(product != null)
            {
                GetCart().AddProduct(product, 1);
            }

            return RedirectToAction("Index");
        }

        public ActionResult RemoveFromCart(int Id)
        {
            var product = db.Products.FirstOrDefault(i => i.Id == Id);

            if (product != null)
            {
                GetCart().DeleteProduct(product);
            }

            return RedirectToAction("Index");
        }
        public Cart GetCart()
        {
            Cart cart = (Cart)Session["Cart"];

            if(cart == null)
            {
                cart = new Cart();
                Session["Cart"] = cart;
            }
            return cart;
        }

        public PartialViewResult Summary()
        {
            return PartialView(GetCart());
        }


        public ActionResult Checkout()
        {
            return View(new ShippingDetails());
        }

        [HttpPost]
        public ActionResult Checkout(ShippingDetails entity)
        {

            var cart = GetCart();

            if(cart.CartLines.Count == 0)
            {
                ModelState.AddModelError("NoProductError", "No product in the shopping cart. ");
            }
            if (ModelState.IsValid)
            {

                SaveOrder(cart, entity);
                cart.Clear();
                return View("Completed");
            }
            else
            {
                return View(entity);

            }
        }

        private void SaveOrder(Cart cart,ShippingDetails entity)
        {
            var order = new Order();
            order.OrderNumber = "A"+ (new Random()).Next(11111, 99999).ToString();
            order.Total = cart.Total();
            order.OrderDate = DateTime.Now;
            order.OrderState = EnumOrderState.Waiting;
            order.Username = User.Identity.Name;
            order.Address = entity.Address;
            order.Adres1 = entity.Adres1;
            order.City = entity.City;
            order.Semt = entity.Semt;
            order.Mahale = entity.Mahale;
            order.Code = entity.Code;
            order.OrderLines = new List<OrderLine>();

            foreach(var pr in cart.CartLines)
            {
                OrderLine orderLine = new OrderLine();
                orderLine.Quantity = pr.Quantity;
                orderLine.Price = pr.Quantity*pr.Product.Price;
                orderLine.ProductId = pr.Product.Id;

                order.OrderLines.Add(orderLine);
            }

            db.Orders.Add(order);
            db.SaveChanges();
        }
    }
}