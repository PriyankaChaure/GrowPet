using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;

namespace Web.CustFilter
{
    public class UserAutho : ActionFilterAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (context.HttpContext.Session.GetString("UserId") == null)
            {
                context.Result = new RedirectToRouteResult(new RouteValueDictionary(new { Controller = "ManageUser", Action = "SignIn", Area = "" }));
            }
        }

    }
}
