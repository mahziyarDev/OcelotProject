using Microsoft.AspNetCore.Mvc.Filters;

namespace Catalog.API.CustomAttributes
{
    public class AccessControlAttribute : ActionFilterAttribute
    {
        public string Permission { get; set; }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            //var token = context.HttpContext.Request.Headers.Authorization....;
            //var userId = token.Claims.....
            //Permissions = product-get-id
            base.OnActionExecuting(context);
        }
    }
}
