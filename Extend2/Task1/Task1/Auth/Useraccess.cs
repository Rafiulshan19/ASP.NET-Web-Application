using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task1.Models;

namespace Task1.Auth
{

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]

    public class Useraccess : AuthorizeCore
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {

            var flag = base.AuthorizeCore(httpContext);
            if (flag)
            {
                var db = new Database();
                int type = db.Users.GetUserType(httpContext.User.Identity.Name);
                if (type == 1) return true;
            }
            return false;

        }
    }
}