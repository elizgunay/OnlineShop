using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineShop.Models
{
    public class Product
    {
        public int Id { get; set; }
        [DisplayName("Product Name")]
        public string Name { get; set; }
        [DisplayName("Description")]
        public string Description { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

        [DisplayName("Upload File")]
        public string Image { get; set; }

        [NotMapped]
        public HttpPostedFileBase FileImage { get; set; }

        public bool isHome { get; set; }
        public bool IsApproved { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}