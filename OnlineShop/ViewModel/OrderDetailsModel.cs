using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShop.ViewModel
{
    public class OrderDetailsModel
    {
        public int OrderId { get; set; }
        public string OrderNumber { get; set; }
        public double Total { get; set; }
        public DateTime OrderDate { get; set; }
        public EnumOrderState OrderState { get; set; }


        public string Username { get; set; }
        public string Address { get; set; }
        public string Adres1 { get; set; }
        public string City { get; set; }
        public string Semt { get; set; }
        public string Mahale { get; set; }
        public string Code { get; set; }


        public virtual List<OrderLineModel> OrderLines { get; set; }


    }

    public class OrderLineModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Image { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

       
    }
}