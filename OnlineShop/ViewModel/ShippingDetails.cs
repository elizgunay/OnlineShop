using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShop.ViewModel
{
    public class ShippingDetails
    {
        public string Username { get; set; }

        [Required(ErrorMessage ="Invalid address.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Invalid address.")]
        public string Adres1 { get; set; }

        [Required(ErrorMessage = "Invalid city.")]
        public string City { get; set; }

        [Required(ErrorMessage = "Invalid")]
        public string Semt { get; set; }

        [Required(ErrorMessage = "Invalid")]
        public string Mahale { get; set; }

        [Required(ErrorMessage = "Invalid")]
        public string Code { get; set; }
    }
}