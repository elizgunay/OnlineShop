using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShop.Models
{
    public class Order
    {
        public int Id { get; set; }
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


        public virtual List<OrderLine> OrderLines { get; set; }
    }

    public class OrderLine
    {
        public int Id { get; set; }

        //Relationship
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }

        public int Quantity { get; set; }

        public double Price { get; set; }

        //Relationship 
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}