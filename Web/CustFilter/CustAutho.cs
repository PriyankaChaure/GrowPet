using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;

namespace Web.CustFilter
{
    public class CustAutho : ActionFilterAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (context.HttpContext.Session.GetString("AdminId") == null)
            {
                context.Result = new RedirectToRouteResult(new RouteValueDictionary(new { Controller = "ManageAdmin", Action = "SignIn", Area = "" }));
            }
        }

    }
}
