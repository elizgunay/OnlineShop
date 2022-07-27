
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using OnlineShop.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OnlineShop.Context
{
    public class IdentityInitializer: CreateDatabaseIfNotExists<IdentityDataContext>

    {
        protected override void Seed(IdentityDataContext context)
        {

            if(!context.Roles.Any(i=>i.Name == "admin"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);
                var role = new ApplicationRole() { Name="admin",Description="admin role"};
                manager.Create(role);
            }

            if (!context.Roles.Any(i => i.Name == "user"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);
                var role = new ApplicationRole() { Name = "user", Description = "user role" };
                manager.Create(role);
            }

            if (!context.Users.Any(i => i.Name == "elizgunay"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser() { Name = "eliz",SurName="gunay",UserName="elizgunay",Email="elizgunay@gmail.com"};
                manager.Create(user,"1234567");
                manager.AddToRole(user.Id,"admin");
                manager.AddToRole(user.Id, "user");
            }

            if (!context.Users.Any(i => i.Name == "elizzgunay"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser() { Name = "elizz", SurName = "gunay", UserName = "elizzgunay", Email = "elizzgunay@gmail.com" };
                manager.Create(user, "1234567");
                manager.AddToRole(user.Id, "user");
            }

            base.Seed(context);
        }
    }
}