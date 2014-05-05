using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using WebModel;

namespace Web.Energizer.UserManagement
{
    public static class UserHelper
    {
        public static User CurrentUser
        {
            get
            {
                //var dc = DCLoader.GetMyDC();
                var user = HttpContext.Current.Session["User"] as User;
                //if (user != null)
                //{

                //    if (dc.Entry(user).State == EntityState.Detached)
                //        dc.Users.Attach(user);
                //    return user;
                //}


                //if (HttpContext.Current.Session["User"] == null &&
                //    HttpContext.Current.User.Identity.IsAuthenticated)
                //{
                //    user =
                //        dc.Users.Include("Permission").FirstOrDefault(
                //            c => c.UserName == System.Web.HttpContext.Current.User.Identity.Name);
                //    HttpContext.Current.Session["User"] = user;
                //}
                return user;
            }
        }
    }
}