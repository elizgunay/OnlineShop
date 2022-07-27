using Microsoft.AspNet.Identity.EntityFramework;
using OnlineShop.Context;
using OnlineShop.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OnlineShop.Identity
{
    public class IdentityDataContext: IdentityDbContext<ApplicationUser>
    {

        public IdentityDataContext() : base("dataConnection")
        {
            //Database.SetInitializer(new IdentityInitializer());

        }


    }
}