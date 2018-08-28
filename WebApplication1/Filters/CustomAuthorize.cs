using System.Web;
using System.Web.Mvc;

public class CustomAuthorizeAttribute : AuthorizeAttribute
{
    
    
    protected override bool AuthorizeCore(HttpContextBase httpContext)
    {
        if (httpContext.User.Identity.IsAuthenticated)
        {
            return true;
        }
        else
        {
            return false;
        }
        
    }
    protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
    {
        filterContext.Result = new HttpUnauthorizedResult();
    }
}