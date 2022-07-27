using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShop.ViewModel
{
    public class Register
    {
        

        [Required]
        [DisplayName("Name")]
        public string Name { get; set; }

        [Required]
        [DisplayName("Surname")]
        public string SurName { get; set; }

        [Required]
        [DisplayName("Username")]
        public string UserName { get; set; }

        [Required]
        [DisplayName("Email")]
        [EmailAddress(ErrorMessage ="Invalid email.")]
        public string Email { get; set; }

        [Required]
        [DisplayName("Password")]
        public string Password { get; set; }

        [Required]
        [DisplayName("RePassword")]
        [Compare("Password",ErrorMessage ="Invalid password.")]
        public string RePassword { get; set; }
    }
}