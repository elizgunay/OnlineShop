using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShop.Models
{
    public enum EnumOrderState
    {
        [Display(Name ="Awaiting approval!")]
        Waiting,
        [Display(Name ="Completed!")]
        Completed
    }
}