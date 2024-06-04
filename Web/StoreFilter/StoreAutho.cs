using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;

namespace Web.StoreFilter
{
    public class StoreAutho : ActionFilterAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (context.HttpContext.Session.GetString("StoreId") == null)
            {
                context.Result = new RedirectToRouteResult(new RouteValueDictionary(new { Controller = "ManageStore", Action = "SignIn", Area = "" }));
            }
        }

    }
}
